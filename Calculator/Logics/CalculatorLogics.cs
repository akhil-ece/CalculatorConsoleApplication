using Calculator.Enums;
using Calculator.Utilities;
using Calculator.Utilities.OperatorInterfaces;
using Calculator.Utilities.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logics
{
    public class CalculatorLogics
    {
        public double Calculate(string userMathString) 
        {
            //We can accept multiple strings and execute them 
            return CalculateMethod(userMathString);
        }
        private double CalculateMethod(string userMathString)
        {
            Stack<MultiStack> multiStack = new Stack<MultiStack>();
            Stack<double> currentStack = new Stack<double> ();
            int inputLength = userMathString.Length;
            char sign = '+';
            for (int i = 0; i < userMathString.Length; i++) 
            {
                char ch = userMathString[i];
                if (char.IsDigit(ch))
                {
                    double val = 0;
                    while (i < inputLength && char.IsDigit(userMathString[i]))
                    {
                        val = val * 10 + userMathString[i] - (int)UtilitiesEnum.CharZeroASCIIValue;
                        i++;
                    }
                    i--;
                    InStackCalculation(currentStack, sign, val);
                }
                else
                {
                    if (ch == '(')
                    {
                        multiStack.Push(new MultiStack(currentStack, sign));
                        sign = '+';
                        currentStack = new Stack<double>();
                    }
                    else
                    if (ch == ')')
                    {
                        MultiStack p = multiStack.Pop();
                        double sum = 0;
                        while (currentStack.Count > 0)
                        {
                            sum += currentStack.Pop();
                        }
                        currentStack = p.stP;
                        sign = p.sign;
                        InStackCalculation(currentStack, sign, sum);
                    }
                    else
                    if (ch != ' ')
                    {
                        sign = ch;
                    }
                }
            }
            double sumFinal = 0;
            while (currentStack.Count > 0)
            {
                sumFinal += currentStack.Pop();
            }
            return sumFinal;
        }
        private void InStackCalculation(Stack<double> st, char sign, double val)
        {
            IOperatorMethods operatorMethod = InStackCalculationOperatorFetch.InStackCalculationOperatorMethod(sign);
            if (operatorMethod != null)
            {
                st.Push(operatorMethod.Calculate(st, sign, val));
            }
        }
    }
}
