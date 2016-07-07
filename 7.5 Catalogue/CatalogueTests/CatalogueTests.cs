using _7._5_Catalogue;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7._5_Catalogue.Tests
{
    /*
      Catalog
        Într-o clasă sunt 30 de elevi. Fiecare elev studiază 12 materii.
        Pentru fiecare materie elevul primește una sau mai multe note.
            Ordonează elevii alfabetic
            Ordonează elevii în funcție de media generală
            Găsește elevii cu o medie generală specifică
            Găsește elevii cu cele mai multe note de 10
            Găsește elevii cu cea mai mică medie generală
            Implementează căutarea și ordonarea în mai multe metode.
 */

    [TestClass()]
    public class UnitTest1
    {
        public pupil[] catalogue = new pupil[0];
        string[] listOfPupils = { "Petrescu George", "Ionescu George", "Albulescu Mihai", "Abrudan Silviu", "Marin Marin" };
          [TestMethod()]
        public void AlphabeticOrderTest()
        {            
            Catalogue.GenerateCatalogue(listOfPupils, ref catalogue);
            pupil[] sortedCatalogue = { new pupil { name = "Abrudan Silviu" },new pupil { name = "Albulescu Mihai" }, new pupil { name = "Ionescu George" }, new pupil { name = "Marin Marin" }, new pupil { name = "Petrescu George" } };
            Catalogue.AlphabeticOrder(ref catalogue);
            CollectionAssert.AreEqual(catalogue,sortedCatalogue);
        }
        [TestMethod()]
        public void GradesAndMeanTest()
        {
            Catalogue.GenerateCatalogue(listOfPupils, ref catalogue);
            int[] mathematicsGrades ={ 10, 9, 9, 9 };
            Catalogue.AddGrades(ref catalogue, "Marin Marin", Objects.Mathematics, mathematicsGrades);
            decimal mathematicsMedian= 9.25m ;
            int index = Catalogue.FindPupilIndex("Marin Marin", catalogue);
            Assert.AreEqual(mathematicsMedian, catalogue[index].Mathematics.mean);
        }
        [TestMethod()]
        public void MeanOrderingTest()
        {
            BuildCatalogue();

            Catalogue.CalculateGeneralMean(ref catalogue);
            Catalogue.OrderByGreatestMean(ref catalogue, 0, catalogue.Length - 1);

            Assert.AreEqual(9.58m, catalogue[0].generalMean);
            Assert.AreEqual(8.00m, catalogue[1].generalMean);
            Assert.AreEqual(7.31m, catalogue[2].generalMean);
            Assert.AreEqual(7.31m, catalogue[3].generalMean);
            Assert.AreEqual(7.00m, catalogue[4].generalMean);
        }
        [TestMethod()]
        public void FindSpecificMeanTest()
        {
            BuildCatalogue();
            Catalogue.CalculateGeneralMean(ref catalogue);
            Catalogue.OrderByGreatestMean(ref catalogue, 0, catalogue.Length - 1);
            int[] indexList = new int[1];
            indexList[0]=Catalogue.SpecificMeanIndex(ref catalogue, 7.31m, 0, catalogue.Length - 1);
            Catalogue.AddSimilar(ref indexList, catalogue, indexList[0]);
            int[] testList = { 2, 3 };
            CollectionAssert.AreEqual(testList, indexList);
            
        }
        [TestMethod()]
        public void SpecificGradePupilsTest()
        {
            BuildCatalogue();
            string[] pupilNames = new string[1];
            Catalogue.PupilsWithMostGrades(ref pupilNames, ref catalogue, 10);
            string[] testList = { "Albulescu Mihai" };
            CollectionAssert.AreEqual(testList, pupilNames);

        }
        [TestMethod()]
        public void LowestMeanPupilsTest()
        {
            BuildCatalogue();
            string[] pupilNames = new string[1];
            Catalogue.LowestMeanPupils(ref catalogue, ref pupilNames);
            string[] testList = { "Ionescu George" };
            CollectionAssert.AreEqual(testList, pupilNames);

        }
        private void BuildCatalogue()
        {
            Catalogue.GenerateCatalogue(listOfPupils, ref catalogue);
            int[] mathematicsGrades = { 10, 9, 9, 9 };
            int[] historyGrades = { 5, 5, 6 };
            int[] physicsGrades = { 6, 5, 9 };
            int[] geographyGrades = { 8, 8, 8 };
            Catalogue.FillAllGrades(ref catalogue, "Abrudan Silviu", mathematicsGrades, historyGrades, physicsGrades, geographyGrades);
            mathematicsGrades = new int[3] { 10, 10, 10 };
            historyGrades = new int[3] { 10, 10, 10 };
            physicsGrades = new int[3] { 10, 10, 8 };
            geographyGrades = new int[4] { 10, 10, 8, 8 };
            Catalogue.FillAllGrades(ref catalogue, "Albulescu Mihai", mathematicsGrades, historyGrades, physicsGrades, geographyGrades);
            mathematicsGrades = new int[3] { 7, 7, 7 };
            historyGrades = new int[3] { 7, 7, 7 };
            physicsGrades = new int[3] { 7, 7, 7 };
            geographyGrades = new int[3] { 7, 7, 7 };
            Catalogue.FillAllGrades(ref catalogue, "Ionescu George", mathematicsGrades, historyGrades, physicsGrades, geographyGrades);
            mathematicsGrades = new int[3] { 8, 8, 8 };
            historyGrades = new int[3] { 8, 8, 8 };
            physicsGrades = new int[3] { 10, 5, 9 };
            geographyGrades = new int[3] { 8, 8, 8 };
            Catalogue.FillAllGrades(ref catalogue, "Marin Marin", mathematicsGrades, historyGrades, physicsGrades, geographyGrades);
            mathematicsGrades = new int[4] { 10, 9, 9, 9 };
            historyGrades = new int[3] { 5, 5, 6 };
            physicsGrades = new int[3] { 6, 5, 9 };
            geographyGrades = new int[3] { 8, 8, 8 };
            Catalogue.FillAllGrades(ref catalogue, "Petrescu George", mathematicsGrades, historyGrades, physicsGrades, geographyGrades);
        }
    }
}


