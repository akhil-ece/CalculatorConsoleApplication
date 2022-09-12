using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Utilities.Operators;
using System.Text.RegularExpressions;

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
        public string ValidateUserInput(string s)
        {
            //Any additional characters
            string resp = string.Empty;
            var charMatch = Regex.Match(s, "[a-zA-Z{}&^%$#@!]+$");

            if (charMatch.Length > 0 && charMatch != null)
            {
                return ("Invalid Character found at " + charMatch.Index.ToString());
            }
            return resp;
        }
    }
}
