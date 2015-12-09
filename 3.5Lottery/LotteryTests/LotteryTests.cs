using _3._5Lottery;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._5Lottery.Tests
{
    [TestClass()]
    public class LotteryTests
    {
        [TestMethod()]
        public void TwoFromFiveTest()
        {
            Assert.AreEqual(10,Lottery.CalculateChance(5,2));
        }
    }
}
