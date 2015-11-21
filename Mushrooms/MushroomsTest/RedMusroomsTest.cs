using Mushrooms;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms.Tests
{
    [TestClass()]
    public class RedMusroomsTest
    {
        [TestMethod()]
        public void Test12Mushrooms()
        {
            Assert.AreEqual(9,RedMushrooms.RedMushroomNo(12,3));
        }
        [TestMethod()]
        public void TestLessRedMushrooms()
        {
            Assert.AreEqual(3, RedMushrooms.RedMushroomNo(12, (double)1/3));
        }
        [TestMethod()]
        public void TestNoDecimalMushroom()
        {
            Assert.AreEqual(7, RedMushrooms.RedMushroomNo(10, 3));
        }
    }
}

