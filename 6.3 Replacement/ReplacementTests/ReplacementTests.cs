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
            int start = 0;
            Assert.AreEqual("TheClearWater",Replacement.Replace("The Water","Clear",ref start,' '));
        }
        [TestMethod()]
        public void ReplaceFirstPosition()
        {
            int start = 0;
            Assert.AreEqual("The Clear Water", Replacement.Replace("1Clear Water", "The ", ref start, '1'));
        }
        [TestMethod()]
        public void ReplaceLastPosition()
        {
            int start = 0;
            Assert.AreEqual("12345678910", Replacement.Replace("123456789A", "10", ref start, 'A'));
        }
        [TestMethod()]
        public void ReplaceInexistent()
        {
            int start = 0;
            Assert.AreEqual("1234", Replacement.Replace("1234", "A ", ref start, '5'));
        }
    }
}
