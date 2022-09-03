using Calculator.Logics;
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App Is Running");
            Console.WriteLine("*************************");
            Console.WriteLine("..");
            Console.WriteLine("Press 'q' to Exit");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter The String to Calculate");
                string sampleInputString = Console.ReadLine();
                if (string.Equals(sampleInputString.ToLower(), "q"))
                {
                    Console.WriteLine("Thank You!!");
                    break;
                }
                CalculatorLogics calculator = new CalculatorLogics();
                PreProcessingLogics preProcessingLogics = new PreProcessingLogics();
                string processedSampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
                Console.WriteLine(sampleInputString + " = " + calculator.Calculate(processedSampleInputString).ToString());
            }
            
        }
    }
}
