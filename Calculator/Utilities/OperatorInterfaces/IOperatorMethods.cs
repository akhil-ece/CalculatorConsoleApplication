using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities.OperatorInterfaces
{
    public interface IOperatorMethods
    {
        public double Calculate(Stack<double> st, char sign, double val);
    }
}
