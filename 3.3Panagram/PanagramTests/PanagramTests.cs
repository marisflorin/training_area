using _3._3Panagram;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._3Panagram.Tests
{
    [TestClass()]
    public class PanagramTests
    {
        [TestMethod()]
        public void IsPanagramTest()
        {
            Assert.AreEqual(true,Panagram.IsPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod()]
        public void IsSentincePanagramTest()
        {
            Assert.AreEqual(true, Panagram.IsPanagram("The quick brown fox jumps over the lazy dog"));
        }
        [TestMethod()]
        public void IsUpCaseSentincePanagramTest()
        {
            Assert.AreEqual(true, Panagram.IsPanagram("The quick brown fox jumps over The lazy dog"));
        }
        [TestMethod()]
        public void TestVoidString()
        {
            Assert.AreEqual(false, Panagram.IsPanagram(""));
        }
        [TestMethod()]
        public void NotPanagram()
        {
            Assert.AreEqual(false, Panagram.IsPanagram("the brown box"));
        }
    }
 }
                                                              
