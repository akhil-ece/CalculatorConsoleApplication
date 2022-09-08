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
        [Description("+")]
        plus,
        [Description("-")]
        minus,
        [Description("*")]
        into,
        [Description("/")]
        divide,
        [Description("%")]
        modulo
    }
    public static class EnumExtensionMethods
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        }
    }
}
