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
        public void PlusTest()
        {
            string sampleInputString = "4 plus 5";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 9;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void MinusTest()
        {
            string sampleInputString = "4 minus 5";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = -1;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
            sampleInputString = "4 - 5";
            actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void DivideTest()
        {
            string sampleInputString = "4 divide 5";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 0.8;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
            sampleInputString = "4 / 5";
            actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void IntoTest()
        {
            string sampleInputString = "4 into 5";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 20;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
            sampleInputString = "4 * 5";
            actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void NegativeResult()
        {
            string sampleInputString = "4 plus 5 minus 45";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = -36;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void DivideMixedTest()
        {
            string sampleInputString = "4 plus 5 minus 45 divide 5";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 0;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void DividePrecisionTest()
        {
            string sampleInputString = "10/3";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 3.333;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void MixedOperatorTest()
        {
            string sampleInputString = "4 plus (5 minus 5) + 5 * 45 + 4 (minus 2)";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 231;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void BracesTest()
        {
            string sampleInputString = "(4 plus 2) - (5 minus 5) + (5 * 45) * (4 (minus 2))";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 456;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
        [TestMethod]
        public void NestedBracesTest()
        {
            string sampleInputString = "(4 plus 2) - (5 minus 5 plus (4 + 2 - 1 + (2 * 9))) + (5 * 5) * (4 - 2)";
            sampleInputString = preProcessingLogics.ReplaceOperatorNames(sampleInputString);
            double expected = 33;
            double actual = calculator.Calculate(sampleInputString);
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Result");
        }
    }
}
