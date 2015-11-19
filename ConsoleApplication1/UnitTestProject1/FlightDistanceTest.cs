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
            Assert.AreEqual(0.030, FlightDistance.DistanceFlown(0.120, 4, 2));
        }
        [TestMethod()]
        public void DistanceForFirstFlightDifferentSpeedRatio()
        {
            Assert.AreEqual(0.015, FlightDistance.DistanceFlown(0.080, 3, 1));
        }
        [TestMethod()]
        public void TestWithMultipleFlights()
        {
            Assert.AreEqual(0.045, FlightDistance.DistanceFlown(0.160, 3, 1));
        }
        [TestMethod()]
        public void TestFor40mDistance()
        {
            Assert.AreEqual(0, FlightDistance.DistanceFlown(0.040, 2, 1));
        }
        [TestMethod()]
        public void Testbigerthan1km()
        {
            Assert.AreEqual(0.296, FlightDistance.DistanceFlown(1.2, 2, 1));
        }
        [TestMethod()]
        public void TestIfMethodsAreEqual()
        {
            Assert.AreEqual(FlightDistance.DistanceFlownFormula(12, 2, 1), FlightDistance.DistanceFlown(12, 2, 1));
        }
    }
    }


