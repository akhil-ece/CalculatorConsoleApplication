using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Utilities.Operators;

namespace Calculator.Logics
{
    public class PreProcessingLogics
    {
        public string ReplaceOperatorNames(string s)
        { 
            s = s.ToLower();
            var operatorDictionaryToProcess = InStackCalculationOperatorFetch.GetAvailableOperators();
            foreach(var oper in operatorDictionaryToProcess)
            {
                s = s.Replace(oper.Key, oper.Value);
            }
            return s;
        }
    }
}
