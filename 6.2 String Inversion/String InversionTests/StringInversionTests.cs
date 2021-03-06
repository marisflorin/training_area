﻿using _6._2_String_Inversion;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6._2_String_Inversion.Tests
{/* 
    Inversare
    Inversează un string folosind recursivitatea.
    */
    [TestClass()]
    public class StringInversionTests
    {
        [TestMethod()]
        public void OneWordTest()
        {
            Assert.AreEqual("esuom",StringInversion.Invert("mouse"));
        }
        [TestMethod()]
        public void TwoLetterTest()
        {
            Assert.AreEqual("es", StringInversion.Invert("se"));
        }
        [TestMethod()]
        public void ThreeWordTest()
        {
            Assert.AreEqual("This is Swiched", StringInversion.Invert("dehciwS si sihT"));
        }
    }
}


