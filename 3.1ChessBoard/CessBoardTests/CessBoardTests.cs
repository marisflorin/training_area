using _3._1ChessBoard;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3._1ChessBoard.Tests
{
    [TestClass()]
    public class CessBoardTests
    {
        [TestMethod()]
        public void TestForOne()
        {
            Assert.AreEqual(1,CessBoard.NumberOFSquares(1));
        }
        [TestMethod()]
        public void TestFor2()
        {
            Assert.AreEqual(5, CessBoard.NumberOFSquares(2));
        }
    }
}
