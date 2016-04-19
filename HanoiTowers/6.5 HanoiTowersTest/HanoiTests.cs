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
        public void TestForTwo()
        {
            Assert.AreEqual(3.0,Hanoi.MovesNumber(2));
        }
        [TestMethod()]
        public void TestForThree()
        {
            Assert.AreEqual(7.0, Hanoi.MovesNumber(3));
        }
        [TestMethod()]
        public void TestFor64()
        {
            Assert.AreEqual(18446744073709551615, Hanoi.MovesNumber(64));
        }
    }
}
