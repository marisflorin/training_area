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
            int[][] triangle = { new int[] { 1 }, new int[] { } };
            int index = 0;
            Pascal.GenerateElement(2,ref triangle,index);
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
        int[][] triangle = { new int[] { 1 }, new int[] { }, new int[] { }, new int[] { }, new int[] { }, new int[] { }, new int[] { } };
            int index = 0;
            Pascal.GenerateElement(7 , ref triangle, index);
            CollectionAssert.AreEqual(triangle[0], testTriangle[0]);
            CollectionAssert.AreEqual(triangle[1], testTriangle[1]);
            CollectionAssert.AreEqual(triangle[2], testTriangle[2]);
            CollectionAssert.AreEqual(triangle[3], testTriangle[3]);
            CollectionAssert.AreEqual(triangle[4], testTriangle[4]);
            CollectionAssert.AreEqual(triangle[5], testTriangle[5]);
            CollectionAssert.AreEqual(triangle[6], testTriangle[6]);
        }
    }
}
