using Goats;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats.Tests
{
    [TestClass()]
    public class GoatsTests
    {
        [TestMethod()]
        public void SingledayTest()
        {
            Assert.AreEqual(8,Goats.HayQuantity(3,1,4,6,1));
        }
        [TestMethod()]
        public void SwitchDaysAndGoatsTest()
        {
            Assert.AreEqual(4, Goats.HayQuantity(3, 8, 4, 8, 3));
        }
        [TestMethod()]
        public void TestTripleDays()
        {
            Assert.AreEqual(45, Goats.HayQuantity(5, 5, 15, 5, 15));
        }
    }
}

