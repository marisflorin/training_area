using _3._7EndsWith888;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._7EndsWith888.Tests
{
    [TestClass()]
    public class EndsWith888Tests
    {
        [TestMethod()]
        public void GetFirstNumberTest()
        {
            Assert.AreEqual(192,EndsWith888.GetNumber(1,888));
        }
        [TestMethod()]
        public void GetNumberForTwoDigitsTest()
        {
            Assert.AreEqual(92, EndsWith888.GetNumber(2, 88));
        }
        [TestMethod()]
        public void GetLastThreeDigitNumberTest()
        {
            Assert.AreEqual(942, EndsWith888.GetNumber(4, 888));
        }
        [TestMethod()]
        public void GetFourDigitNumberTest()
        {
            Assert.AreEqual(2192, EndsWith888.GetNumber(9, 888));
        }
    }
}
