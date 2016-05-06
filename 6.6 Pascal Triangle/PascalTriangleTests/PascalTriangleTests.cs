using _6._6_Pascal_Triangle;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6._6_Pascal_Triangle.Tests
{
  
    [TestClass()]
    public class PascalTriangleTests
    {
        [TestMethod()]
        public void GenerateTriangleTest()
        {
            int[][] testTriangle = {
                new int[] { 1 },
                new int[] { 1, 1 }};
            int[][] triangle = new int[2][];            
            Pascal.GenerateElements(2,ref triangle);
            CollectionAssert.AreEqual(triangle[0],testTriangle[0]);
            CollectionAssert.AreEqual(triangle[1],testTriangle[1]);
        }
        [TestMethod()]
        public void GenerateMultipleLevelsTest()
        {
            int[][] testTriangle = {
                new int[] { 1 },
                new int[] { 1, 1 },
                new int[] { 1, 2, 1 },
                new int[] { 1, 3, 3, 1 },
                new int[] { 1, 4, 6, 4, 1 },
                new int[] { 1, 5, 10, 10, 5, 1},
                new int[] { 1, 6, 15, 20, 15, 6, 1 }
            };
        int[][] triangle=new int[7][];        
            Pascal.GenerateElements(7 , ref triangle);
            CollectionAssert.AreEqual(triangle[0], testTriangle[0]);
            CollectionAssert.AreEqual(triangle[1], testTriangle[1]);
            CollectionAssert.AreEqual(triangle[2], testTriangle[2]);
            CollectionAssert.AreEqual(triangle[3], testTriangle[3]);
            CollectionAssert.AreEqual(triangle[4], testTriangle[4]);
            CollectionAssert.AreEqual(triangle[5], testTriangle[5]);
            CollectionAssert.AreEqual(triangle[6], testTriangle[6]);
        }
        [TestMethod()]
        public void TestReturnBiggest1()
        {
           int[][] triangle = new int[7][];
           Pascal.GenerateElements(7, ref triangle);
           Assert.AreEqual(Pascal.ReturnBiggest(triangle, 7),20);        
        }
        [TestMethod()]
        public void TestReturnBiggest2()
        {
            int[][] triangle = new int[6][];
            Pascal.GenerateElements(6, ref triangle);
            Assert.AreEqual(Pascal.ReturnBiggest(triangle, 6), 10);
        }
        [TestMethod()]
        public void GeneratePrintable()
        {
            string[,] testTriangle = {
                { " "," "," "," "," "," "," "," "," "," 1 " },
                { " "," "," "," "," "," "," "," "," 1 "," 1 " },
                { " "," "," "," "," "," "," "," 1 "," 2 "," 1 " },
                { " "," "," "," "," "," "," 1 "," 3 "," 3 "," 1 " },
                { " "," "," "," "," "," 1 "," 4 "," 6 "," 4 "," 1 " },
                { " "," "," "," "," 1 "," 5 "," 10"," 10"," 5 "," 1 " },
                { " "," "," "," 1 "," 6 "," 15"," 20"," 15"," 6 "," 1 " },
                { " "," "," 1 "," 7 "," 21"," 35"," 35"," 21"," 7 "," 1 " },
                { " "," 1 "," 8 "," 28"," 56"," 70"," 56"," 28"," 8 "," 1 " },
                { " 1 "," 9 "," 36"," 84","126","126"," 84"," 36"," 9 "," 1 " }
  // If printed with one blank (" ") between elements the triangle will be perfectly alligned
            };
            string[,] triangle=new string[1,1];
            Pascal.GenerateTriangle(10,ref triangle);
            CollectionAssert.AreEqual(triangle, testTriangle);        
        }
    }
}
