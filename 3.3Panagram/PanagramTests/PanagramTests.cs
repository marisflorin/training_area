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
            Assert.AreEqual(true,Panagram.IsPanagram("abc"));
        }
    }
}

