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
        [TestMethod]
        public void TestNightTimeUnder20km()
        {
            Assert.AreEqual(70, TripCost.TotalTripCost(10, 0759));
        }
        [TestMethod]
        public void TestIfValidTime()
        {
            Assert.AreEqual(0, TripCost.TotalTripCost(10,0760));
        }
        [TestMethod]
        public void TestDayTimeBetween21And60km()
        {
            Assert.AreEqual(240, TripCost.TotalTripCost(30, 900));
        }
    }
}
