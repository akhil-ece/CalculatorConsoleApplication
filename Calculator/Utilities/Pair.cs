using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities
{
    public class MultiStack
    {
        public Stack<double> stP;
        public char sign;
        public MultiStack(Stack<double> stP, char sign)
        {
            this.stP = stP;
            this.sign = sign;
        }   
    }
}
