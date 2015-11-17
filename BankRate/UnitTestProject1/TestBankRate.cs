using BankRate;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate.Tests
{
    [TestClass()]
    public class TestBankRate
    {
        [TestMethod()]
        public void MonthlyBankRateTest1()
        {
            Assert.AreEqual(510,BankRateCalculator.MonthlyBankRate(1000,1,2,12));
        }
        [TestMethod()]
        public void MonthlyBankRateTest2()
        {
            Assert.AreEqual(505, BankRateCalculator.MonthlyBankRate(1000, 2, 2, 12));
        }
        [TestMethod()]
        public void MonthlyBankRateTest3()
        {
            Assert.AreEqual(1010, BankRateCalculator.MonthlyBankRate(12000, 12, 12, 12));
        }
      
    }
}


