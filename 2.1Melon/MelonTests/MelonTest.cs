using _2._1Melon;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._1Melon.Tests
{
    [TestClass()]
    public class MelonTest
    {
        [TestMethod()]
        public void MelonEvenTest()
        {
            Assert.AreEqual("Yes",MelonShare.MelonShareable(6));
        }
        [TestMethod()]
        public void MelonOddTest()
        {
            Assert.AreEqual("No", MelonShare.MelonShareable(5));
        }
        [TestMethod()]
        public void MelonTestForTwokg()
        {
            Assert.AreEqual("No", MelonShare.MelonShareable(2));
        }
        [TestMethod()]
        public void MelonNegativeValues()
        {
            Assert.AreEqual("No", MelonShare.MelonShareable(-6));
        }
    }
}

