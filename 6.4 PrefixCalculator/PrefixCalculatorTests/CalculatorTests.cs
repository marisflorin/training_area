using PrefixCalculator;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixCalculator.Tests
{/*
    Calculator
Scrie un program care imită un calculator de buzunar în formă prefixată.
Operațiile posibile sunt:
adunare/scădere
înmulțire/împărțire
suportă numere reale
Notă: În forma prefixată operatorii apar înainte operanzilor.
Exemple pentru format prefixată:
* 3 4 e echivalent cu 3 * 4
* + 1 1 2, e echivalent cu (1 + 1) * 2
+ / * + 56 45 46 3 - 1 0.25 e echivalent cu ((56 + 45) * 46) / 3 + (1 - 0.25)
*/
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void PrefixCalculatorTest()
        {
            string input ="+ 3 4";
            Assert.AreEqual(7, Calculator.PrefixCalculator(input));
        }
        [TestMethod()]
        public void TestSubstraction()
        {
            string input = "+ - 3 4 6";
            Assert.AreEqual(5, Calculator.PrefixCalculator(input));
        }
        [TestMethod()]
        public void TestMultipleOperation1()
        {
            string input = "+ / * + 56 45 46 3 - 1 0.25";
            double result = Calculator.PrefixCalculator(input);
            Assert.AreEqual(1549.41667, Math.Round(result, 5));
        }
        [TestMethod()]
        public void TestMultipleOperation2()
        {
            string input = "* + 3 3 + 2 2";
            double result = Calculator.PrefixCalculator(input);
            Assert.AreEqual(24, Math.Round(result, 5));
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid characters present of invalid input")]
        public void TestInvalidOperator()
        {
            string input = "* + 3 3 ~ 2 2";
            double result = Calculator.PrefixCalculator(input);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Invalid characters present of invalid input")]
        public void TestTooManySigns()
        {
            string input = "* + 3 3 +- 2 2";
            double result = Calculator.PrefixCalculator(input);
        }
    }
}
