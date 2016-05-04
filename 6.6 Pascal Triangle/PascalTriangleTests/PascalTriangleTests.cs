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
    }
}
