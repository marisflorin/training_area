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
        [TestMethod()]
        public void NoPrefixTest()
        {
            Assert.AreEqual("", Prefix.FindPrefix("bab", "aac"));
        }
        [TestMethod()]
        public void VoidStringTest()
        {
            Assert.AreEqual("", Prefix.FindPrefix("bab", ""));
        }
        [TestMethod()]
        public void DifferentLengthTest()
        {
            Assert.AreEqual("aaa", Prefix.FindPrefix("aaab", "aaaabbaa"));
        }
    }
}

