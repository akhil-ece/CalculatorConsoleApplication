using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities
{
    public class Pair
    {
        public Stack<double> stP;
        public char sign;
        public Pair(Stack<double> stP, char sign)
        {
            this.stP = stP;
            this.sign = sign;
        }   
    }
}
