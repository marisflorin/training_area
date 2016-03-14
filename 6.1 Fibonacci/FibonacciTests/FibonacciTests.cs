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
       
        [TestMethod()]
        public void TestForFourth()
          {
             Assert.AreEqual(2, Fibonacci.CalculateFibonacci(4));
          }
        [TestMethod()]
        public void TestForThird()
        {
            Assert.AreEqual(1, Fibonacci.CalculateFibonacci(3));
        }
        [TestMethod()]
        public void TestForSecond()
        {
            Assert.AreEqual(1, Fibonacci.CalculateFibonacci(2));
        }
        [TestMethod()]
        public void TestForFirst()
        {
            Assert.AreEqual(0, Fibonacci.CalculateFibonacci(1));
        }
    }

    }
