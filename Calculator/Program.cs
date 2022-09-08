using Calculator.Logics;
using Calculator.Utilities;
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

                //Validate user input

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
        //private ValidationResponse ValidateInput(string inputMathString)
        //{
        //    ValidationResponse validation = new ValidationResponse();
        //    foreach (var ch in inputMathString)
        //    {
        //        if (IsAnInValidLetter(ch))
        //        {
        //            validation.IsValid = false;
        //        }
        //    }
        //    return validation;
        //}
        //private bool IsAnInValidLetter(char ch)
        //{ 
        //    if((ch >= 'a' && ch <='z') || (ch >= 'A' && ch <= 'Z'))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
