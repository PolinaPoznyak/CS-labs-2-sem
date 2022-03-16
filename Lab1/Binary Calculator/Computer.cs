using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Calculator
{
    class Computer : IComputer
    {
        public int And(int a, int b) => a & b;
        public int Not(int a) => ~a;
        public int Or(int a, int b) => a | b;
        public int Xor(int a, int b) => a ^ b;
    }
}
