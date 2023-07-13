using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Memory
    {
        string memory = "";
        string shortT1 = "";
        string shortT2 = "";
        public string Mem { get => memory; set => memory = value; }
        public string ShortT1 { get => shortT1; set => shortT1 = value; }
        public string ShortT2 { get => shortT2; set => shortT2 = value; }
        public int typS { get; set; }
    }
}
