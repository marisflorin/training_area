using System;
using _2._6Roman_Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RomanNumbersTest
{
    // Convertește un număr dat, între 1 și 100, în cifre romane.
    // I - 1; V - 5; X - 10; L - 50; C - 100
    //De ex: 4 - IV; 8 - VIII; 9 - IX; 15 - XV; 30 - XXX; 39 - XXXIX 41 - XLI; 45 - XLV; 99 - XCIX

    [TestClass]
    public class ConvertorTests
    {
        [TestMethod]
        public void TestFor3()
        {
            Assert.AreEqual("III", Convertor.ConvertedResult(3));
        }
        [TestMethod]
        public void TestFor4()
        {
            Assert.AreEqual("IV", Convertor.ConvertedResult(4));
        }
        [TestMethod]
        public void TestFor8()
        {
            Assert.AreEqual("VIII", Convertor.ConvertedResult(8));
        }
        [TestMethod]
        public void TestFor9()
        {
            Assert.AreEqual("IX", Convertor.ConvertedResult(9));
        }
    }
}
