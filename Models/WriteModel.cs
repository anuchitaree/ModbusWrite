using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusWrite.Models
{
    public class WriteModel
    {
        public int Id { get; set; }
        public int RegType { get; set; }
        public int UnitIdentify { get; set; }
        public string RegAddrString { get; set; }
        public int RegAddr { get; set; }

        public int DecValue { get; set; }
        public string DecString { get; set; }
        public string HexValue { get; set; }
        public int Int32Value { get; set; }
    }
}
