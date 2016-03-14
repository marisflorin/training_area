using Fibonacci;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        public void TestForEight()
        {
            Assert.AreEqual(13,Fibonacci.CalculateFibonacci(8));
        }
    }
}
