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

            byte[] firstArray=new byte[8]; BaseConversion.ConvertToBit(156,ref firstArray);
            byte[] secondArray = { 1, 0, 0, 1, 1, 1, 0, 0 };
       
            CollectionAssert.AreEqual(firstArray, secondArray);
          }
        [TestMethod()]
        public void ConvertToBitTestfor70000()
        {

            byte[] firstArray = new byte[8]; BaseConversion.ConvertToBit(70000, ref firstArray);
            byte[] secondArray = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,1,0,1,1,1,0,0,0,0 };

            CollectionAssert.AreEqual(firstArray, secondArray);
        }
    }
}
