using PrefixCalculator;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixCalculator.Tests
{/*
    Calculator
Scrie un program care imită un calculator de buzunar în formă prefixată.
Operațiile posibile sunt:
adunare/scădere
înmulțire/împărțire
suportă numere reale
Notă: În forma prefixată operatorii apar înainte operanzilor.
Exemple pentru format prefixată:
* 3 4 e echivalent cu 3 * 4
* + 1 1 2, e echivalent cu (1 + 1) * 2
+ / * + 56 45 46 3 - 1 0.25 e echivalent cu ((56 + 45) * 46) / 3 + (1 - 0.25)
*/
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void PrefixCalculatorTest()
        {
            string[] input = { "+", "3", "4" };
            Assert.AreEqual(7,Calculator.PrefixCalculator(input));
        }
    }
}
