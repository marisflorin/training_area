using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5_Catalogue
{   
    public enum Objects
        {   Mathematics,
            History,
            Physics,
            Geography
        }
      public struct objectStudied
    {
        public List<int> grades;
        public decimal mean;
        
    }
    public struct pupil
    {   
        public string name;
        public decimal generalMean;
        public int specificCount;
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
        public static void AlphabeticOrder(ref pupil[] catalogue) // bublesort
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
        public static void AddGrades(ref pupil[] catalogue,string pupilName,Objects objectStudied,int[] grades )
        {
            int index = FindPupilIndex(pupilName, catalogue);
            switch (objectStudied)
            {
                case Objects.Mathematics:
                    if (catalogue[index].Mathematics.grades == null) catalogue[index].Mathematics.grades = new List<int>();
                    catalogue[index].Mathematics.grades.AddRange(grades);
                    catalogue[index].Mathematics.mean = CalculateMean(catalogue[index].Mathematics.grades);
                    break;
                case Objects.History:
                    if (catalogue[index].History.grades == null) catalogue[index].History.grades = new List<int>();
                    catalogue[index].History.grades.AddRange(grades);
                    catalogue[index].History.mean = CalculateMean(catalogue[index].History.grades);
                    break;
                case Objects.Geography:
                    if (catalogue[index].Geography.grades == null) catalogue[index].Geography.grades = new List<int>();
                    catalogue[index].Geography.grades.AddRange(grades);
                    catalogue[index].Geography.mean = CalculateMean(catalogue[index].Geography.grades);
                    break;
                case Objects.Physics:
                    if (catalogue[index].Physics.grades == null) catalogue[index].Physics.grades = new List<int>();
                    catalogue[index].Physics.grades.AddRange(grades);
                    catalogue[index].Physics.mean = CalculateMean(catalogue[index].Physics.grades);
                    break;
            }
          }
        public static int FindPupilIndex(string pupilName, pupil[] catalogue) // liniar search
        {
            for (int i = 0; i < catalogue.Length; i++)
                if (catalogue[i].name == pupilName) return i;
            throw new System.ArgumentException("Pupil name not in catalogue");
        }
        public static decimal CalculateMean(List<int> grades)
        {
            decimal sum = 0;
            for (int i = 0; i < grades.Count; i++)
                sum += grades[i];
            return sum / grades.Count;
        }
        public static void FillAllGrades(ref pupil[] catalogue,string pupilName, int[] mathematicsGrades,int[] historyGrades,int[] physicsGrades,int[] geographyGrades )
        {
            AddGrades(ref catalogue, pupilName, Objects.Mathematics, mathematicsGrades);
            AddGrades(ref catalogue, pupilName, Objects.History, historyGrades);
            AddGrades(ref catalogue, pupilName, Objects.Physics, physicsGrades);
            AddGrades(ref catalogue, pupilName, Objects.Geography, geographyGrades);
        }
        public static void CalculateGeneralMean(ref pupil[] catalogue)
        {
            decimal sum = 0;
            for (int i = 0; i < catalogue.Length; i++)
            { sum = catalogue[i].Mathematics.mean+ catalogue[i].History.mean + catalogue[i].Physics.mean + catalogue[i].Geography.mean ;
              catalogue[i].generalMean=Decimal.Round(sum/4,2);
            }
        }
        public static void OrderByGreatestMean(ref pupil[] catalogue,int beg, int end) // SelectionSort
        {
            if (beg == end) return;
            pupil temp = catalogue[beg];
            int indexOfGreatest = beg;
            for (int i = beg + 1; i <= end; i++)
                if (catalogue[indexOfGreatest].generalMean < catalogue[i].generalMean) indexOfGreatest = i;
            Swap(ref catalogue, beg, indexOfGreatest);
            OrderByGreatestMean(ref catalogue, beg + 1, end);
        }
        public static int SpecificMeanIndex(ref pupil[] catalogue, decimal specificMean,int beg, int end)
        {
            if (beg > end) throw new ArgumentException("There is no pupil having the searched median");
            int mid = beg + end / 2;
            if (catalogue[mid].generalMean == specificMean) return mid;
            return catalogue[mid].generalMean > specificMean ? SpecificMeanIndex(ref catalogue, specificMean, beg, mid) : SpecificMeanIndex(ref catalogue, specificMean, mid, end);           
        }
        public static void AddSimilar(ref int[] list,pupil[] catalogue,int index)
        {
            int i = index-1;
            while (catalogue[index].generalMean==catalogue[i].generalMean && i>=0)
            {
                Array.Resize(ref list, list.Length + 1);
                ShiftLeft(list);
                list[0] = i;
                i--;
            }
            i = index+1;
            while (catalogue[index].generalMean == catalogue[i].generalMean && i < catalogue.Length)
            {
                Array.Resize(ref list, list.Length + 1);                
                list[list.Length-1] = i;
                i++;
            }
        }
        private static void ShiftLeft(int[] list)
        {
            for (int j = list.Length - 1; j > 0; j--)
                list[j] = list[j - 1];
        }
        public static void CountSpecificGrade(ref pupil[] catalogue, int gradeToCount)
        {
            for (int i = 0; i < catalogue.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < catalogue[i].Mathematics.grades.Count; j++)
                    if (gradeToCount == catalogue[i].Mathematics.grades[j]) k++;

                for (int j = 0; j < catalogue[i].History.grades.Count; j++)
                    if (gradeToCount == catalogue[i].History.grades[j]) k++;

                for (int j = 0; j < catalogue[i].Physics.grades.Count; j++)
                    if (gradeToCount == catalogue[i].Physics.grades[j]) k++;

                for (int j = 0; j < catalogue[i].Geography.grades.Count; j++)
                    if (gradeToCount == catalogue[i].Geography.grades[j]) k++;
                catalogue[i].specificCount = k;
            }        
          }

        public static void MergeSortGrades(ref pupil[] catalogue, int beg, int end) //merge sort
        {
            int mid = (beg + end) / 2;
            if (beg < end && end < catalogue.Length)
            {
                MergeSortGrades(ref catalogue, beg, mid);
                MergeSortGrades(ref catalogue, mid + 1, end);
                MergeLists(ref catalogue, beg, mid, end);
            }
            else return;
        }
        public static void MergeLists(ref pupil[] catalogue,int beg, int mid, int end)
        {
            int length = end + 1;
            pupil[] aux=new pupil[length];
            int firstIndex = beg;
            int secondIndex = mid + 1;
            int auxIndex = beg;
            while (firstIndex <= mid && secondIndex <= end)
                aux[auxIndex++] = catalogue[firstIndex].specificCount > catalogue[secondIndex].specificCount ? catalogue[firstIndex++] : catalogue[secondIndex++];
            while (firstIndex <= mid) aux[auxIndex++] = catalogue[firstIndex++];
            while (secondIndex <= end) aux[auxIndex++] = catalogue[secondIndex++];
            for(int i=beg; i<=end;i++) catalogue[i]=aux[i];
        }
        public static void PupilsWithMostGrades(ref string[] pupilNames,ref pupil[] catalogue,int searchedGrade )
        {
            CountSpecificGrade(ref catalogue, searchedGrade);
            MergeSortGrades(ref catalogue, 0, catalogue.Length - 1);
            if (catalogue[0].specificCount > 0)
            {
                pupilNames[0] = catalogue[0].name;
                int i = 1;
                while (catalogue[0].specificCount == catalogue[i].specificCount && i >= 0)
                {
                    Array.Resize(ref pupilNames, pupilNames.Length + 1);
                    pupilNames[i] = catalogue[i].name;
                    i++;
                }
            }
        }
    }
}
