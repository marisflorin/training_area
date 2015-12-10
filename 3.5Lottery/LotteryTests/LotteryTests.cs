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
        public void SixFrom49SecondCategoryTest()
        {
            Assert.AreEqual(0.00184499, Lottery.CalculateChance(49, 6, 2));
        }
        [TestMethod()]
        public void SixFrom49ThirdCategoryTest()
        {
            Assert.AreEqual(0.096861972, Lottery.CalculateChance(49, 6, 3));
        }
        [TestMethod()]
        public void FiveFrom40Test()
        {
            Assert.AreEqual(0.000151974, Lottery.CalculateChance(40, 5));
        }
        [TestMethod()]
        public void Error()
        {
            Assert.AreEqual(100, Lottery.CalculateChance(6, 6));
        }

    }
}
