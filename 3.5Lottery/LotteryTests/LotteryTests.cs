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
        [TestMethod()]
        public void SixFrom49Test()
        {
            Assert.AreEqual(0.000007151, Lottery.CalculateChance(49, 6));
        }
        [TestMethod()]
        public void ThreeFromSix2ndCategoryTest()
        {
            Assert.AreEqual(45, Lottery.CalculateChance(6, 3,2));
        }
        [TestMethod()]
        public void SixFrom49SecoundCategoryTest()
        {
            Assert.AreEqual(0.00184499, Lottery.CalculateChance(49, 6, 2));
        }
    }
}
