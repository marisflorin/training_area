using HanoiTowers;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers.Tests
{
    /* 
Turnurile din Hanoi
    Călugării dintr-un templul din Benareu ls trebuie să mute 64 de discuri de pe un turn pe altul.
    În afară de cele două turnuri mai aa dispoziție un singur alt turn care e suficient de sacru pentru a putea fi folosit.
    Cele 64 de discuri au dimensiuni diferite.Iar călugării trebuie să respecte două reguli:
    un singur disc poate fi mutat la un moment dat
    un disc mai mare nu poate fi mutat peste un disc mai mic
    */
    [TestClass()]
    public class HanoiTests
    {
        [TestMethod()]
        public void TestForOne()
        {
            string[] firstTower = new string[2];
            string[] auxTower = new string[2];
            string[] secondTower = new string[2];
            firstTower[0] = "1"; auxTower[0] = ""; secondTower[0] = "";
            firstTower[1] = ""; auxTower[1] = ""; secondTower[1] = "1";
            ulong level = 0;
            int numberOfDisks = 1;
            string[] generatedFirstTower = new string[1], generatedSecondTower = new string[1], generatedAuxTower = new string[1];
            Hanoi.InitializeArrays(1, ref generatedFirstTower, ref generatedAuxTower, ref generatedSecondTower);
            Hanoi.GenerateMoves(numberOfDisks, ref generatedFirstTower, ref generatedAuxTower, ref generatedSecondTower, ref level);
            CollectionAssert.AreEqual(firstTower, generatedFirstTower);
            CollectionAssert.AreEqual(auxTower, generatedAuxTower);
            CollectionAssert.AreEqual(secondTower, generatedSecondTower);
        }
        [TestMethod()]
        public void TestForTwo()
        {
            string[] firstTower = new string[4];
            string[] auxTower = new string[4];
            string[] secondTower = new string[4];
            firstTower[0] = "2 1"; auxTower[0] = ""; secondTower[0] = "";
            firstTower[1] = "2"; auxTower[1] = "1"; secondTower[1] = "";
            firstTower[2] = ""; auxTower[2] = "1"; secondTower[2] = "2";
            firstTower[3] = ""; auxTower[3] = ""; secondTower[3] = "2 1";
            ulong level = 0;
            string[] generatedFirstTower = new string[1], generatedSecondTower = new string[1], generatedAuxTower = new string[1];
            Hanoi.InitializeArrays(2, ref generatedFirstTower, ref generatedAuxTower, ref generatedSecondTower);
            int numberOfDisks = 2;
            Hanoi.GenerateMoves(numberOfDisks, ref generatedFirstTower, ref generatedAuxTower, ref generatedSecondTower, ref level);
            CollectionAssert.AreEqual(firstTower, generatedFirstTower);
            CollectionAssert.AreEqual(auxTower, generatedAuxTower);
            CollectionAssert.AreEqual(secondTower, generatedSecondTower);
        }
        [TestMethod()]
        public void TestForThree()
        {
            string[] firstTower = new string[8];
            string[] auxTower = new string[8];
            string[] secondTower = new string[8];
            firstTower[0] = "3 2 1"; auxTower[0] = ""; secondTower[0] = "";
            firstTower[1] = "3 2"; auxTower[1] = ""; secondTower[1] = "1";
            firstTower[2] = "3"; auxTower[2] = "2"; secondTower[2] = "1";
            firstTower[3] = "3"; auxTower[3] = "2 1"; secondTower[3] = "";
            firstTower[4] = ""; auxTower[4] = "2 1"; secondTower[4] = "3";
            firstTower[5] = "1"; auxTower[5] = "2"; secondTower[5] = "3";
            firstTower[6] = "1"; auxTower[6] = ""; secondTower[6] = "3 2";
            firstTower[7] = ""; auxTower[7] = ""; secondTower[7] = "3 2 1";
            ulong level = 0;
            string[] generatedFirstTower = new string[1], generatedSecondTower = new string[1], generatedAuxTower = new string[1];
            Hanoi.InitializeArrays(3, ref generatedFirstTower, ref generatedAuxTower, ref generatedSecondTower);
            int numberOfDisks = 3;
            Hanoi.GenerateMoves(numberOfDisks, ref generatedFirstTower, ref generatedAuxTower, ref generatedSecondTower, ref level);
            CollectionAssert.AreEqual(firstTower, generatedFirstTower);
            CollectionAssert.AreEqual(auxTower, generatedAuxTower);
            CollectionAssert.AreEqual(secondTower, generatedSecondTower);
            Assert.AreEqual(7.0, level);
        }

        /* [TestMethod()]
         public void TestFor64()
         {
             Assert.AreEqual(18446744073709551615, Hanoi.MovesNumber(64));
         } */
    }
}
