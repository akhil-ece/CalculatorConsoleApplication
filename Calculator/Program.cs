using Calculator.Logics;
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sampleInputString = "4 plus (5 minus 5) + 5 * 45 + 4 (minus 2)";
            CalculatorLogics calculator = new CalculatorLogics();
            PreProcessingLogics preProcessingLogics = new PreProcessingLogics();
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            Console.WriteLine(calculator.Calculate(sampleInputString));
        }
    }
}
