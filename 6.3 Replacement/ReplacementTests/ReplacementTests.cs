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
    }
}
