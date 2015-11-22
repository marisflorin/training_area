using ParquetFlooring;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParquetFlooring.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void SheetsNeededTest()
        {
            Assert.AreEqual(10,FlooringSurface.SheetsNeeded(2,2,230,20,15));
        }
    }
}

