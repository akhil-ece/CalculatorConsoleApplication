using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Calculator.Enums
{
    internal enum UtilitiesEnum
    {
        CharZeroASCIIValue = 48
    }
    internal enum OperatorsEnum
    {
        [Description("plus")]
        plus,
        [Description("minus")]
        minus,
        [Description("into")]
        into,
        [Description("divide")]
        divide
    }
}
