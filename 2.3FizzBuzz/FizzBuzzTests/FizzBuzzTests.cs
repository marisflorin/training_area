using FizzBuzz;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void BuzzerTest()
        {
            Assert.AreEqual("Buzz",Fizzbuzz.Buzzer(6));
        }
    }
}

