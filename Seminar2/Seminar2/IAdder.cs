using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    /**
     * 1. Add a class which implements the interface IAdder
     * 2. Create in the Main method an instance of the class
     * 3. Call the Add() method on the instance on two doubles which you read from user input
    */
    internal interface IAdder
    {
        double Add(double operand1, double operand2);
    }
}
