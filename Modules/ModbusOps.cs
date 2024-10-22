using System;

namespace ModbusWrite.Modules
{
    public static class ModbusOps
    {
        public static (short regf, short regs) UInt32ToShort(string svalue)
        {
            var value = int.Parse(svalue);
            if (value > 999999999)
                return (regf: 0, regs: 0);
            byte[] bytes = BitConverter.GetBytes(value);
            short firstHalf = BitConverter.ToInt16(bytes, 0);
            short secondHalf = BitConverter.ToInt16(bytes, 2);
            return (regf:secondHalf, regs:firstHalf);
        }
    }
}
