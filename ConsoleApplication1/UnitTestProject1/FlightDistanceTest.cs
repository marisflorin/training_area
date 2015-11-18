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
            Assert.AreEqual(2, FlightDistance.DistanceFlown(12, 2, 1));
        }
    }
}

