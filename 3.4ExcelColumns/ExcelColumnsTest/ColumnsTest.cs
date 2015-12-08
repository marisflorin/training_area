using _3._4ExcelColumns;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._4ExcelColumns.Tests
{
    [TestClass()]
    public class ColumnsTest
    {
        [TestMethod()]
        public void ColumnNameTest()
        {
            Assert.AreEqual("D",ExcelComumns.ColumnName(4));
        }
    }
}

