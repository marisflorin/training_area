using System;
using RentDebt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentDebtTests
{
    [TestClass]
    public class TotalRentTests
    {
        [TestMethod]
        public void Test10days()
        {
            Assert.AreEqual(118, TotalRent.TotalMonthlyRent(100, 9));
        }
    }
}
