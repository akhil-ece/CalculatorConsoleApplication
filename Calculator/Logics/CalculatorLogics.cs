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
                char currentCharacter = userMathString[i];
                if (char.IsDigit(currentCharacter))
                {
                    //Logic for maintaining the current number(say entered 123, we need to prepare the number 123 from "123")
                    double currentNumberVal = 0;
                    while (i < inputLength && char.IsDigit(userMathString[i]))
                    {
                        currentNumberVal = currentNumberVal * 10 + userMathString[i] - (int)UtilitiesEnum.CharZeroASCIIValue;
                        i++;
                    }
                    i--;
                    InStackCalculation(currentStack, sign, currentNumberVal);
                }
                else
                {
                    if (currentCharacter == '(')
                    {
                        multiStack.Push(new MultiStack(currentStack, sign));
                        sign = '+';
                        currentStack = new Stack<double>();
                    }
                    else
                    if (currentCharacter == ')')
                    {
                        MultiStack previouslyPushedStack = multiStack.Pop();
                        double sum = 0;
                        //Finishing the current stack before processing the collected stack
                        while (currentStack.Count > 0)
                        {
                            sum += currentStack.Pop();
                        }
                        //Updating the Current Stack with the collected stack
                        currentStack = previouslyPushedStack.stP;
                        sign = previouslyPushedStack.sign;
                        InStackCalculation(currentStack, sign, sum);
                    }
                    else
                    if (currentCharacter != ' ')
                    {
                        sign = currentCharacter;
                    }
                }
            }
            //End operation where all the items of stack(which are either positive or negative numbers getting added up)
            double sumFinal = 0;
            while (currentStack.Count > 0)
            {
                sumFinal += currentStack.Pop();
            }
            return sumFinal;
        }
        private void InStackCalculation(Stack<double> currentStack, char sign, double val)
        {
            //Sign specific class will be fetched and will be updated to the stack
            IOperatorMethods operatorMethod = InStackCalculationOperatorFetch.InStackCalculationOperatorMethod(sign);
            if (operatorMethod != null)
            {
                currentStack.Push(operatorMethod.Calculate(currentStack, sign, val));
            }
        }
    }
}
