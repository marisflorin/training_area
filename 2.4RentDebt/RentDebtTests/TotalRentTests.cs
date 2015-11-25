using System;
using RentDebt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentDebtTests
{
    [TestClass]
    public class TotalRentTests
    {
        [TestMethod]
        public void Test1To10days()
        {
            Assert.AreEqual(118, TotalRent.TotalMonthlyRent(100, 9));
        }
        [TestMethod]
        public void Test11To30days()
        {
            Assert.AreEqual(160, TotalRent.TotalMonthlyRent(100, 12));
        }
        [TestMethod]
        public void Test31To40days()
        {
            Assert.AreEqual(500, TotalRent.TotalMonthlyRent(100, 40));
        }
    }
}
