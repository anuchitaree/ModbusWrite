using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusWrite.Modules
{
    public static class Convertion
    {
        public static string Dec2Hex(int dec)
        {
            string hexStr = dec.ToString("X");
            if (hexStr.Length == 8)
                hexStr = hexStr.Substring(4, 4);
            return hexStr.PadLeft(4, '0');
        }
        public static int Short2Int(int value0, int value1)
        {
            var HSB = (Int32)value0 << 16;
            var LSB = (Int32)value1;
            return HSB | (LSB & 0x0000FFFF);
        }
    }
}
