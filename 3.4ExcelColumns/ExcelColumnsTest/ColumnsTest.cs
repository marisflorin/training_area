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
            Assert.AreEqual("D",ExcelComumns.ColumnName(4));
        }
        [TestMethod()]
        public void TwoLetterTest()
        {
            Assert.AreEqual("AM", ExcelComumns.ColumnName(39));
        }
    }
}

