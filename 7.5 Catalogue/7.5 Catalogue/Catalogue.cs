﻿using System;
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
        public decimal median;
        
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
                    catalogue[index].Mathematics.median = CalculateMedian(catalogue[index].Mathematics.grades);
                    break;
                case Objects.History:
                    if (catalogue[index].History.grades == null) catalogue[index].History.grades = new List<int>();
                    catalogue[index].History.grades.AddRange(grades);
                    catalogue[index].History.median = CalculateMedian(catalogue[index].History.grades);
                    break;
                case Objects.Geography:
                    if (catalogue[index].Geography.grades == null) catalogue[index].Geography.grades = new List<int>();
                    catalogue[index].Geography.grades.AddRange(grades);
                    catalogue[index].Geography.median = CalculateMedian(catalogue[index].Geography.grades);
                    break;
                case Objects.Physics:
                    if (catalogue[index].Physics.grades == null) catalogue[index].Physics.grades = new List<int>();
                    catalogue[index].Physics.grades.AddRange(grades);
                    catalogue[index].Physics.median = CalculateMedian(catalogue[index].Physics.grades);
                    break;
            }
            }
        public static int FindPupilIndex(string pupilName, pupil[] catalogue)
        {
            for (int i = 0; i < catalogue.Length; i++)
                if (catalogue[i].name == pupilName) return i;
            throw new System.ArgumentException("Pupil name not in catalogue");
        }
        public static decimal CalculateMedian(List<int> grades)
        {
            decimal sum = 0;
            for (int i = 0; i < grades.Count; i++)
                sum += grades[i];
            return sum / grades.Count;
        }
    }
}
