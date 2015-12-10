using _3._6Anagrams;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._6Anagrams.Tests
{
    [TestClass()]
    public class AnagramCalculatorTests
    {
        [TestMethod()]
        public void AnagramABTest()
        {
            Assert.AreEqual(1,AnagramCalculator.CalculateAnagramNum("ab"));
        }
        [TestMethod()]
        public void AnagramABCTestt()
        {
            Assert.AreEqual(5, AnagramCalculator.CalculateAnagramNum("abc"));
        }
        [TestMethod()]
        public void AnagramVoid()
        {
            Assert.AreEqual(0, AnagramCalculator.CalculateAnagramNum(""));
        }
        [TestMethod()]
        public void AnagramLetter()
        {
            Assert.AreEqual(0, AnagramCalculator.CalculateAnagramNum("A"));
        }

    }
}
