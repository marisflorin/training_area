using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRecursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecursion.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TEsteru()
        {
            int[][] toTest =
            {
                new int[] {1} ,
                new int[] {1,1},
                new int[] {1,3,1},
                new int[] {1,3,3,1}
            };
            int[][] jagged = { new int[] { }, new int[] { }, new int[] { }, new int[] { } };
            Program.Parcurs(ref jagged, 4, 0);
            CollectionAssert.AreEqual(jagged[0], toTest[0]);
            CollectionAssert.AreEqual(jagged[1], toTest[1]);
            CollectionAssert.AreEqual(jagged[2], toTest[2]);
            CollectionAssert.AreEqual(jagged[3], toTest[3]);
        }
    }
}