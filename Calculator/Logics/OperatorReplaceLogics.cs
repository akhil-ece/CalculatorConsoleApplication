using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logics
{
    public class OperatorReplaceLogics
    {
        public string ReplaceOperatorNames(string s)
        { 
            s = s.ToLower();
            s = s.Replace("plus", "+");
            s = s.Replace("minus", "-");
            s = s.Replace("into", "*");
            s = s.Replace("divide", "/");
            return s;
        }
    }
}
