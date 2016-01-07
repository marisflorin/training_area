using _4._1BaseConversion;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace _4._1BaseConversion.Tests
{
    [TestClass()]
    public class BaseConversionTests
    {
        [TestMethod()]
        public void ConvertToBitTestfor156()
        {
            List<byte> first = new List<byte>();
            for (int i = 0; i < BaseConversion.ConvertToBit(156).Length; i++)
            {
                first.Add(BaseConversion.ConvertToBit(156)[i]);
            }

            List<byte> second = new List<byte>();
            second.Add(1);
            second.Add(0);
            second.Add(0);
            second.Add(1);
            second.Add(1);
            second.Add(1);
            second.Add(0);
            second.Add(0);

            CollectionAssert.AreEqual(first, second);
          }
        [TestMethod()]
        public void ConvertToBitTestfor2500()
        {
            List<byte> first = new List<byte>();
            for (int i = 0; i < BaseConversion.ConvertToBit(2500).Length; i++)
            {
                first.Add(BaseConversion.ConvertToBit(2500)[i]);
            }
            
            List<byte> second = new List<byte>();
            second.Add(0);
            second.Add(0);
            second.Add(0);
            second.Add(0);
            second.Add(1);
            second.Add(0);
            second.Add(0);
            second.Add(1);
            second.Add(1);
            second.Add(1);
            second.Add(0);
            second.Add(0);
            second.Add(0);
            second.Add(1);
            second.Add(0);
            second.Add(0);

            CollectionAssert.AreEqual(first, second);
        }
    }
}
