using _7._4ElectionResults;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7._4ElectionResults.Tests
{
    /*  Centralizare alegeri
            La alegeri fiecare secție de votare trimite o listă de candidați și numărul de voturi.
            Listele sunt ordonate descrescător în funcție de numărul de voturi.
            Crează o funcție care să ajute la centralizarea voturilor.*/
    [TestClass()]
    public class ElectionTests
    {
        [TestMethod()]
        public void CentralizeVotesTest()
        {
            string[] candidateNames = { "Andrei", "Cornel", "Daniel", "Ionel", "Sorin" };
            Candidate[,] localResults = new Candidate[4, 5] { { new Candidate("Ionel", 90), new Candidate("Cornel", 60), new Candidate("Andrei", 30), new Candidate("Sorin", 21), new Candidate("Daniel", 1) },
                                                    { new Candidate("Daniel", 80), new Candidate("Andrei", 50), new Candidate("Cornel", 20), new Candidate("Ionel", 10), new Candidate("Sorin", 2) },
                                                    { new Candidate("Ionel", 84), new Candidate("Daniel", 73), new Candidate("Andrei", 50), new Candidate("Sorin", 4), new Candidate("Cornel", 1) },
                                                     { new Candidate("Ionel", 104), new Candidate("Daniel", 60), new Candidate("Andrei", 20), new Candidate("Cornel", 10), new Candidate("Sorin", 2) },
                                                    };
            Candidate[] finalList = { new Candidate("Ionel", 288), new Candidate("Daniel", 214), new Candidate("Andrei", 150), new Candidate("Cornel", 91), new Candidate("Sorin", 29) };
            Candidate[] centralisedList=new Candidate [0];
            ElectionResults.CentralizeVotes(candidateNames,localResults, ref centralisedList);
            CollectionAssert.AreEqual(finalList,centralisedList);
        }
    }
}
