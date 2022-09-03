using Calculator.Utilities.OperatorInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities.Operators
{
    internal class DivideOperator : IOperatorMethods
    {
        public double Calculate(Stack<double> st, char sign, double val)
        {
            if (val == 0)
            {
                throw new DivideByZeroException();
            }
            return st.Pop() / val;
        }
    }
}
