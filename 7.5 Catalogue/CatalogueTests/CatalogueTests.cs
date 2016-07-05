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
        public void GradesAndMedianTest()
        {
            Catalogue.GenerateCatalogue(listOfPupils, ref catalogue);
            int[] mathematicsGrades ={ 10, 9, 9, 9 };
            Catalogue.AddGrades(ref catalogue, "Marin Marin", Objects.Mathematics, mathematicsGrades);
            decimal mathematicsMedian= 9.25m ;
            int index = Catalogue.FindPupilIndex("Marin Marin", catalogue);
            Assert.AreEqual(mathematicsMedian, catalogue[index].Mathematics.median);
        } 
    }
}


