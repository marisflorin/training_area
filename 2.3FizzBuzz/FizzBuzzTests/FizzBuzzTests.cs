using FizzBuzz;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void BuzzerTestBuzz()
        {
            Assert.AreEqual("Buzz",Fizzbuzz.Buzzer(6));
        }
        [TestMethod()]
        public void BuzzerTestFizz()
        {
            Assert.AreEqual("Fizz", Fizzbuzz.Buzzer(10));
        }
        [TestMethod()]
        public void BuzzerTestFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", Fizzbuzz.Buzzer(15));
        }
        [TestMethod()]
        public void BuzzerTestNothing()
        {
            Assert.AreEqual("", Fizzbuzz.Buzzer(14));
        }

    }
}

