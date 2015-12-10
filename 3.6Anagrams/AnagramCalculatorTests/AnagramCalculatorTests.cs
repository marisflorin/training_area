using _3._6Anagrams;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._6Anagrams.Tests
{
    [TestClass()]
    public class AnagramCalculatorTests
    {
        [TestMethod()]
        public void CalculateAnagramNumTest()
        {
            Assert.AreEqual(1,AnagramCalculator.CalculateAnagramNum("ab"));
        }
    }
}
