using Calculator.Enums;
using Calculator.Utilities.OperatorInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities.Operators
{
    public class InStackCalculationOperatorFetch
    {
        //Need to add operators in the Enum and add simple logic here and add operator specific class in the operators folder
        public static Dictionary<string, string> GetAvailableOperators()
        {
            Dictionary<string, string> operators = new Dictionary<string, string>();
            operators.Add(OperatorsEnum.plus.ToString(), EnumExtensionMethods.GetEnumDescription(OperatorsEnum.plus));
            operators.Add(OperatorsEnum.minus.ToString(), EnumExtensionMethods.GetEnumDescription(OperatorsEnum.minus));
            operators.Add(OperatorsEnum.divide.ToString(), EnumExtensionMethods.GetEnumDescription(OperatorsEnum.divide));
            operators.Add(OperatorsEnum.into.ToString(), EnumExtensionMethods.GetEnumDescription(OperatorsEnum.into));
            return operators;
        }
        public static IOperatorMethods InStackCalculationOperatorMethod(char sign)
        {
            IOperatorMethods operatorMethods = null;
            switch (sign)
            {
                case '+':
                    operatorMethods = new PlusOperator();
                    break;
                case '-':
                    operatorMethods = new MinusOperator();
                    break;
                case '*':
                    operatorMethods = new IntoOperator();
                    break;
                case '/':
                    operatorMethods = new DivideOperator();
                    break;
                default:
                    return operatorMethods;
            }
            return operatorMethods;
        }
    }
}
