using _3._7EndsWith888;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._7EndsWith888.Tests
{
    [TestClass()]
    public class EndsWith888Tests
    {
        [TestMethod()]
        public void GetNumberTest()
        {
            Assert.AreEqual(192,EndsWith888.GetNumber(1,888));
        }
    }
}
