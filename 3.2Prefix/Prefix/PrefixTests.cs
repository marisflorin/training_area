using _3._2Prefix;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._2Prefix.Tests
{
    [TestClass()]
    public class PrefixTests
    {
        [TestMethod()]
        public void FindPrefixTest()
        {
            Assert.AreEqual("aa",Prefix.FindPrefix("aab","aac"));
        }
    }
}

