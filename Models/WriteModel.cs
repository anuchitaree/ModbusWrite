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
        public string Address { get; set; }
        public string DecValue { get; set; }
        public string HexValue { get; set; }
    }
}
