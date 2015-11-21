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
    }
}

