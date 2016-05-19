using _7._3WordSort;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7._3WordSort.Tests
{
    //   Ordonează cuvintele
    //   Găsește și ordonează cuvintele dintr-un text în funcție de numărul de apariții.

    [TestClass()]
    public class WordSortTests
    {
        [TestMethod()]
        public void SortWordsTest()
        {
            string textSequence = "one one one three two two/five,four one, two one three, two, three.four:six";
            Word[] outputList, expectedList;
            outputList = new Word[1];
            expectedList = new Word[]{ new Word() { word = "one", instances = 5 },
                new Word() { word = "two", instances = 4 },
                new Word() { word = "three", instances = 3 },
                new Word() { word = "four", instances = 2 },
                new Word() { word = "five", instances = 1 },
                new Word() { word = "six", instances = 1 }
                };
            WordSort.SortWords(textSequence, ref outputList);
            CollectionAssert.AreEqual(expectedList,outputList);
        }
    }
}
