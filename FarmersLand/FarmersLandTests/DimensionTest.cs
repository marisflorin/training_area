using FarmersLand;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersLand.Tests
{
    [TestClass()]
    public class DimensionTest
    {
        [TestMethod()]
        public void TestFor400m()
        {
            Assert.AreEqual(400,Dimension.SideDimension(20,100));
        }
    }
}

