using _6._3_Replacement;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6._3_Replacement.Tests
{
    [TestClass()]
    public class ReplacementTests
    {
        [TestMethod()]
        public void ReplaceTest()
        {
            Assert.AreEqual("TheClearWater",Replacement.Replace("The Water","Clear",4));
        }
        [TestMethod()]
        public void ReplaceFirstPosition()
        {
            Assert.AreEqual("The Clear Water", Replacement.Replace("1Clear Water", "The ", 1));
        }
        [TestMethod()]
        public void ReplaceLastPosition()
        {
            Assert.AreEqual("12345678910", Replacement.Replace("123456789A", "10", 10));
        }
        [TestMethod()]
        public void ReplaceOutsidePosition()
        {
            Assert.AreEqual("1234", Replacement.Replace("1234", "A ", 5));
        }
    }
}
