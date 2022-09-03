﻿using Calculator.Utilities.OperatorInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities.Operators
{
    internal class IntoOperator : IOperatorMethods
    {
        public double Calculate(Stack<double> st, char sign, double val)
        {
            return st.Pop() * val;
        }
    }
}
