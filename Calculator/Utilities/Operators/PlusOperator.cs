using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Utilities.OperatorInterfaces;

namespace Calculator.Utilities.Operators
{
    internal class PlusOperator : IOperatorMethods
    {
        public double Calculate(Stack<double> currentStack, char sign, double val)
        {
            return val;
        }
    }
}
