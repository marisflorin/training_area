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
            Assert.AreEqual(9,PavementBlocks.BlockNumber(6,6,200));
         }
        [TestMethod()]
        public void TestwithDecimals()
        {
            Assert.AreEqual(4, PavementBlocks.BlockNumber(6, 6, 400));
        }
        [TestMethod()]
        public void TestWithRealisticUnits()
        {
            Assert.AreEqual(900, PavementBlocks.BlockNumber(6, 6, 20));
        }
    }
}

