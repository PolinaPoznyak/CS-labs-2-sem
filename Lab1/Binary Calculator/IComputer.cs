using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Calculator
{
    interface IComputer
    {
        int And(int a, int b);
        int Or(int a, int b);
        int Xor(int a, int b);
        int Not(int a);
    }
}
