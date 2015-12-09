using _3._4ExcelColumns;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._4ExcelColumns.Tests
{
    [TestClass()]
    public class ColumnsTest
    {
        [TestMethod()]
        public void OneLetterTest()
        {
            Assert.AreEqual("B",ExcelComumns.ColumnName(2));
        }
        [TestMethod()]
        public void TwoLetterTest()
        {
            Assert.AreEqual("SK", ExcelComumns.ColumnName(505));
        }
        [TestMethod()]
        public void ThreeLetterTest()
        {
            Assert.AreEqual("AIR", ExcelComumns.ColumnName(928));
        }
        [TestMethod()]
        public void TestForNegative()
        {
            Assert.AreEqual("", ExcelComumns.ColumnName(-928));
        }
        [TestMethod()]
        public void TestForZero()
        {
            Assert.AreEqual("", ExcelComumns.ColumnName(0));
        }
        [TestMethod()]
        public void TestForAZ()
        {
            Assert.AreEqual("AZ", ExcelComumns.ColumnName(52));
        }
    }
}

