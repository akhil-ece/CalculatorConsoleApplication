using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Calculator.Logics;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorUnitTest
    {
        CalculatorLogics calculator = new CalculatorLogics();
        PreProcessingLogics preProcessingLogics = new PreProcessingLogics();
        [TestMethod]
        public void SimpleInput()
        {
            string sampleInputString = "4 plus 5";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 9;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void MixedOperatorTest()
        {
            string sampleInputString = "4 plus (5 minus 5) + 5 * 45 + 4 (minus 2)";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 231;
            double actual = calculator.Calculate(sampleInputString);    
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
