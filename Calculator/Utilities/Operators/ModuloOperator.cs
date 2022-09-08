using Calculator.Utilities.OperatorInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities.Operators
{
    internal class ModuloOperator : IOperatorMethods
    {
        public double Calculate(Stack<double> currentStack, char sign, double val)
        {
            return currentStack.Pop() % val;
        }
    }
}
