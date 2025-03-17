using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Adder : IAdder
    {
        public double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }
}
