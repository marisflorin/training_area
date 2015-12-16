using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7EndsWith888
{
    // Cub
    // Un om de știință vrea să știe toate numerele al căror cub se termină cu 888. 
    // Ajută-l prin a-i face un program care pentru numărul k, 
    // întoarce al k-lea număr al cărui cub e 888.
    //  Exemplu: dacă k e 1, rezultatul e 192
    public class EndsWith888
    {
        static void Main(string[] args)
        {
        }
        public static double GetNumber(int rootNumber, int endingDigits)
        {

            int rootCount = 0;
            double cubeRoot = 0;
            double[] solutionArray = new double[1];
            do
            {
                cubeRoot++;
                if (IsValidRoot(endingDigits, cubeRoot))
                {
                    AddSolutionToArray(ref rootCount, cubeRoot, ref solutionArray);
                }

            } while (rootCount < rootNumber && IsNotBiggerDigitNumber(endingDigits, cubeRoot));

            if (rootCount == rootNumber) return solutionArray[rootCount - 1];
            int root = GetFirstDigits(rootNumber, ref rootCount, solutionArray);
            int solutionIndex = GetIndex(rootCount, solutionArray);
            return BuildNumber(endingDigits, solutionArray, root, solutionIndex);

        }

        private static double BuildNumber(int endingDigits, double[] solutionArray, int root, int solutionIndex)
        {
            return root * (Math.Pow(10, GetNumberOfDigits(endingDigits))) + solutionArray[solutionIndex];
        }

        private static int GetIndex(int rootCount, double[] solutionArray)
        {
            return rootCount % solutionArray.Length != 0 ? rootCount % solutionArray.Length - 1 : 3;
        }

        private static int GetFirstDigits(int rootNumber, ref int rootCount, double[] solutionArray)
        {
            int root = 0;
            while (rootCount < rootNumber)
            {
                root++;
                foreach (int element in solutionArray)
                {
                    rootCount++;
                    if (rootCount == rootNumber) break;
                }
            }

            return root;
        }

        private static void AddSolutionToArray(ref int rootCount, double cubeRoot, ref double[] solutionArray)
        {
            int i = 0;
            double[] temp = new double[rootCount + 1];
            foreach (double element in solutionArray)
            {
                temp[i] = element;
                i++;
            }
            temp[rootCount] = cubeRoot;
            solutionArray = temp;
            rootCount++;
        }

        private static bool IsNotBiggerDigitNumber(int endingDigits, double cubeRoot)
        {
            return GetNumberOfDigits(cubeRoot) <= GetNumberOfDigits(endingDigits);
        }

        private static bool IsValidRoot(int endingDigits, double cubeRoot)
        {
            int power = GetNumberOfDigits(endingDigits);
            return Math.Pow(cubeRoot,3) % Math.Pow(10, power) == endingDigits;
        }

        private static int GetNumberOfDigits(double endingDigits)
        {
            return endingDigits.ToString().Length;
        }
    }
}
