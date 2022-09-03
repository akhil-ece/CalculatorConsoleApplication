using Calculator.Utilities.OperatorInterfaces;
using Calculator.Utilities.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utilities
{
    public class InStackCalculationOperatorFetch
    {
        public static IOperatorMethods InStackCalculationOperatorMethod(char sign)
        {
            IOperatorMethods operatorMethods = null;
            switch (sign)
            {
                case '+':
                    operatorMethods =  new PlusOperator();
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
