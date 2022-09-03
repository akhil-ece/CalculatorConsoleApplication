using Calculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logics
{
    public class CalculatorLogics
    {
        public double Calculate(string s)
        {
            Stack<Pair> stp = new Stack<Pair>();
            Stack<int> st = new Stack<int> ();
            int n = s.Length;
            char sign = '+';
            for (int i = 0; i < s.Length; i++) 
            {
                char ch = s[i];
                if (char.IsDigit(ch))
                {
                    int val = 0;
                    while (i < n && char.IsDigit(s[i]))
                    {
                        val = val * 10 + s[i] - 48;//getting value from a character number
                        i++;
                    }
                    i--;
                    InStackCalculation(st, sign, val);
                }
                else
                {
                    if (ch == '(')
                    {
                        stp.Push(new Pair(st, sign));
                        sign = '+';
                        st = new Stack<int>();
                    }
                    else
                    if (ch == ')')
                    {
                        Pair p = stp.Pop();
                        int sum = 0;
                        while (st.Count > 0)
                        {
                            sum += st.Pop();
                        }
                        st = p.stP;
                        sign = p.sign;
                        InStackCalculation(st, sign, sum);
                    }
                    else
                    if (ch != ' ')
                    {
                        sign = ch;
                    }
                }
            }
            int sumFinal = 0;
            while (st.Count > 0)
            {
                sumFinal += st.Pop();
            }
            return sumFinal;
        }
        public void InStackCalculation(Stack<int> st, char sign, int val)
        {
            switch(sign)
            {
                case '+':
                    st.Push(val);
                    break;
                case '-':
                    st.Push(-val);
                    break;
                case '*':
                    st.Push(st.Pop() * val);
                    break ;
                case '/':
                    st.Push(st.Pop() / val);
                    break ;
                default:
                    break;
            }
        }
    }
}
