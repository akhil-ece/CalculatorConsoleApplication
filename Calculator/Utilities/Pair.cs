using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities
{
    public class Pair
    {
        public Stack<int> stP;
        public char sign;
        public Pair(Stack<int> stP, char sign)
        {
            this.stP = stP;
            this.sign = sign;
        }   
    }
}
