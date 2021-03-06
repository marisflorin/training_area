﻿using System;
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
        [TestMethod]
        public void TestDayTimeOver60km()
        {
            Assert.AreEqual(420, TripCost.TotalTripCost(70, 2059));
        }
         [TestMethod]
        public void TestNightTimeOver60km()
        {
            Assert.AreEqual(560, TripCost.TotalTripCost(70, 2100));
        }
        [TestMethod]
        public void TestNightTimeBetween21And60km()
        {
            Assert.AreEqual(300, TripCost.TotalTripCost(30, 2100));
        }
        [TestMethod]
        public void TestNightTimeUnder21km()
        {
            Assert.AreEqual(0, TripCost.TotalTripCost(0, 0759));
        }
    }
}
