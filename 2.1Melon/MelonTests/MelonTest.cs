using _2._1Melon;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2._1Melon.Tests
{
    [TestClass()]
    public class MelonTest
    {
        [TestMethod()]
        public void MelonShareableTest()
        {
            Assert.AreEqual("Yes",MelonShare.MelonShareable(6));
        }
    }
}

