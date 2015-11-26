using System;
using _2._5Taxi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiTests
{
    [TestClass]
    public class TripCostsTest
    {
        [TestMethod]
        public void TestDayTimeUnder20km()
        {
            Assert.AreEqual(20, TripCost.TotalTripCost(4, 900));
        }
    }
}
