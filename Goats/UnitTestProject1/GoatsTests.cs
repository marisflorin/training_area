using Goats;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats.Tests
{
    [TestClass()]
    public class GoatsTests
    {
        [TestMethod()]
        public void SwitchDaysAndGoatsTest()
        {
            Assert.AreEqual(4,Goats.HayQuantity(1,3,4,3,1));
        }
    }
}

