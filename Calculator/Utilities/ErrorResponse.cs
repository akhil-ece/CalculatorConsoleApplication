using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities
{
    internal class ValidationResponse
    {
        public bool IsValid { get; set; }
        public int ErrorChracter { get; set; }
        public string ErrorMessage { get; set; }
    }
}
