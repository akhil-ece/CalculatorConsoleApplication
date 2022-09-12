using Calculator.Logics;
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App Is Running");
            Console.WriteLine("Operations Allowed as of Now");
            Console.WriteLine("plus or +");
            Console.WriteLine("minus or -");
            Console.WriteLine("into or *");
            Console.WriteLine("divide or /");
            Console.WriteLine("Sample string: 4 plus (5 minus 5) + 5 * 45 + 4 (minus 2)");
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
                var errorPositionString = preProcessingLogics.ValidateUserInput(sampleInputString);
                if (!string.IsNullOrEmpty(errorPositionString))
                {
                    Console.WriteLine(errorPositionString);
                    continue;
                }
                try 
                {
                    var calculatedResult = calculator.Calculate(processedSampleInputString);
                    Console.WriteLine(sampleInputString + " = " + calculatedResult.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error In Calculation" + " Reference: " + e.Message);
                }
                
            }
            
        }
    }
}
