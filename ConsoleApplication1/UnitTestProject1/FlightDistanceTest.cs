using ConsoleApplication1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class FlightDistanceTest
    {
        [TestMethod()]
        public void DistanceForFirstFlight()
        {
            Assert.AreEqual(0.002, FlightDistance.DistanceFlown(0.012, 4, 2));
        }
        [TestMethod()]
        public void DistanceForFirstFlightDifferentSpeedRatio()
        {
            Assert.AreEqual(0.003, FlightDistance.DistanceFlown(0.016, 3, 1));
        }

    }
}

