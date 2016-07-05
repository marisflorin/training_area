using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5_Catalogue
{
      public struct objectStudied
    {
        public List<int> grades;
        decimal median;
    }
    public struct pupil
    {
        public string name;
        public objectStudied Mathematics;
        public objectStudied History;
        public objectStudied Physics;
        public objectStudied Geography;
    }
    public class Catalogue
    {
        static void Main(string[] args)
        {
        }
        public static void AlphabeticOrder(ref pupil[] catalogue)
        {
            bool isOrdered = true;
            do
            {
                isOrdered = true;
                for (int i = 0; i < catalogue.Length-1; i++)
                {                
                    if (string.Compare(catalogue[i].name, catalogue[i + 1].name, true) > 0)
                    {
                        isOrdered = false;
                        Swap(ref catalogue, i, i + 1);
                    }
                }
            } while (!isOrdered); 

        }
        public static void Swap(ref pupil[] catalogue, int firstIndex,int secondIndex)
        {
            pupil temp = catalogue[firstIndex];
            catalogue[firstIndex] = catalogue[secondIndex];
            catalogue[secondIndex] = temp;
        }
        public static void GenerateCatalogue(string[] listOfPupils, ref pupil[] catalogue)
        {
            Array.Resize(ref catalogue, listOfPupils.Length);
            for (int i = 0; i < listOfPupils.Length; i++)
                catalogue[i] = new pupil { name = listOfPupils[i] };                
        }
    }
}
