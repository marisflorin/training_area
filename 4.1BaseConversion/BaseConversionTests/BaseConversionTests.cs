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

            byte[] firstArray = new byte[8];
            BaseConversion.ConvertToBit(156, ref firstArray);
            byte[] secondArray = { 1, 0, 0, 1, 1, 1, 0, 0 };

            CollectionAssert.AreEqual(firstArray, secondArray);
        }
        [TestMethod()]
        public void ConvertToBitTestfor70000()
        {

            byte[] firstArray = new byte[8];
            BaseConversion.ConvertToBit(70000, ref firstArray);
            byte[] secondArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0 };

            CollectionAssert.AreEqual(firstArray, secondArray);
        }
        [TestMethod()]
        public void TestBitwiseNOTfor300()
        {

            byte[] firstArray = new byte[8];
            BaseConversion.ConvertToBit(300, ref firstArray);
            byte[] notArray = new byte[16];
            BaseConversion.BitwiseNOT(firstArray, ref notArray);
            byte[] secondArray = { 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 1 };

            CollectionAssert.AreEqual(notArray, secondArray);
        }
        [TestMethod()]
        public void TestBitwiseANDfor300and200()
        {

            byte[] firstArray, secondArray, resultArray;
            BuildArrays(300, 200, out firstArray, out secondArray, out resultArray);
            BaseConversion.BitwiseOPS(firstArray, secondArray, ref resultArray,'&');
            byte[] andArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 };

            CollectionAssert.AreEqual(resultArray, andArray);
        }
        [TestMethod()]
        public void TestBitwiseORfor300and200()
        {

            byte[] firstArray, secondArray, resultArray;
            BuildArrays(300,200,out firstArray,out secondArray, out resultArray);
            BaseConversion.BitwiseOPS(firstArray, secondArray, ref resultArray,'|');
            byte[] orArray = { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0 };
            CollectionAssert.AreEqual(resultArray, orArray);
        }
        [TestMethod()]
        public void TestBitwiseXORfor10and2()
        {
            byte[] firstArray, secondArray, resultArray;
            BuildArrays(10,2,out firstArray, out secondArray,out resultArray);
            BaseConversion.BitwiseOPS(firstArray, secondArray, ref resultArray, '^');
            byte[] xorArray = { 0, 0, 0, 0, 1, 0, 0, 0 };
            CollectionAssert.AreEqual(resultArray, xorArray);
        }

        private static void BuildArrays(int firstNumber,int secondNumber, out byte[] firstArray,out byte[] secondArray,out byte[] resultArray)
        {
            firstArray = new byte[8];
            BaseConversion.ConvertToBit(firstNumber, ref firstArray);
            secondArray = new byte[8];
            BaseConversion.ConvertToBit(secondNumber, ref secondArray);
            resultArray = new byte[8];
        }
        [TestMethod()]
        public void TestRightHandShift8()
        {
            byte[] testArray = {0, 1, 1, 0, 1, 1, 1, 0 }; 
            BaseConversion.RightHandShift(ref testArray, 8);
            byte[] shiftedArray = { 0, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(testArray, shiftedArray);
        }
        [TestMethod()]
        public void TestLeftHandShift3()
        {
            byte[] testArray = {1, 1, 1, 1 };
            BaseConversion.LeftHandShift(ref testArray, 4);
            byte[] shiftedArray = { 1, 1, 1, 1, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(testArray, shiftedArray);
        }
        [TestMethod()]
        public void TestLessThan()
        {
            byte[] smallArray = { 0,0, 0, 1,1};
            byte[] bigArray = { 0, 0, 1, 0 };
            Assert.AreEqual(false, BaseConversion.LessThan(smallArray,bigArray));
        }
        [TestMethod()]
        public void TestLessThan200and300()
        {
            byte[] smallArray= new byte[8];
            BaseConversion.ConvertToBit(300, ref smallArray);
            byte[] bigArray = new byte[8];
            BaseConversion.ConvertToBit(200, ref bigArray);       
            Assert.AreEqual(false, BaseConversion.LessThan(smallArray, bigArray));
        }
    }
}