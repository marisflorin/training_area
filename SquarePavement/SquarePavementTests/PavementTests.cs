using SquarePavement;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquarePavement.Tests
{
    [TestClass()]
    public class PavementTests
    {
        [TestMethod()]
        public void TestNoDecimals()
        {
            Assert.AreEqual(9,PavementBlocks.BlockNumber(6,6,2));
         }
        [TestMethod()]
        public void TestwithDecimals()
        {
            Assert.AreEqual(4, PavementBlocks.BlockNumber(6, 6, 4));
        }
    }
}

