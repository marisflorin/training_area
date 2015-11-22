using Athlete;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Athlete.Tests
{
    [TestClass()]
    public class RepetitionsNoTests
    {
        [TestMethod()]
        public void TotalRepetitionsTest()
        {
            Assert.AreEqual(25,RepetitionsNo.TotalRepetitions(5));
        }
        [TestMethod()]
        public void NegativeRoundTest()
        {
            Assert.AreEqual(0, RepetitionsNo.TotalRepetitions(-5));
        }
    }
}

