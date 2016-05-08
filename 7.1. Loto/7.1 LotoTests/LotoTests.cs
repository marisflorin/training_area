using _7._1.Loto;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7._1.Loto.Tests
{
    /*Extragere loto
Trebuie ca tot timpul numerele extrase la loto să fie afișate la public în ordine crescătoare
și nu în ordinea în care au fost extrase.
Scrie o funcție care face asta.
*/
    [TestClass()]
    public class LotoTests
    {
        [TestMethod]
        public void TestLotoNumbers()
        {
            int[] extractedSeq = { 23, 12, 2, 45, 8, 10 };
            int[][] printResult =  {
               new int[] {23},
               new int[] {12,23 },
               new int[] {2,12,23 },
               new int[] {2,12,23,45 },
               new int[] {2,8,12,23,45},
               new int[] {2,8,10,12,23,45 }
                };
            int[][] printSequence = new int[6][];
            Loto.PrintOut(extractedSeq,ref printSequence);
            CollectionAssert.AreEqual(printResult[0], printSequence[0]);
            CollectionAssert.AreEqual(printResult[1], printSequence[1]);
            CollectionAssert.AreEqual(printResult[2], printSequence[2]);
            CollectionAssert.AreEqual(printResult[3], printSequence[3]);
            CollectionAssert.AreEqual(printResult[4], printSequence[4]);
            CollectionAssert.AreEqual(printResult[5], printSequence[5]);            
        }
    }
}
