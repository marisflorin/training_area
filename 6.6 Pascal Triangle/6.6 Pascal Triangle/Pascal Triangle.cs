using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_Pascal_Triangle
{
   public class Pascal
    {
        public static void GenerateTriangle(int level, ref string[,] printable)
        {
            int[][] triangle = new int[level][];
            GenerateElements(level, ref triangle);
            int length = ReturnBiggest(triangle, level).ToString().Length;
            if (IsEven(length)) ++length;
            string blank = ComplementaryBlank(length);
            printable = new string[level, level];
            FillIn(printable, level-1, level-1, level, triangle, length, blank);
        }

        private static void FillIn(string[,] printable,int i,int j,int level, int[][] triangle, int length, string blank)
        {
            if (i < 0) return;
                if (OutsideOfLimit(i, j, level, triangle)) printable[i, j] = blank;
                else printable[i, j] = MakeString(triangle[i][level - j - 1], length);

                if (j == 0) FillIn(printable, --i, level - 1, level, triangle, length, blank);
                else FillIn(printable, i, --j, level, triangle, length, blank);

        }

        private static bool OutsideOfLimit(int i, int j, int level, int[][] triangle)
        {
            return j < level - triangle[i].Length;
        }

        private static bool IsEven(int length)
        {
            return length % 2 == 0;
        }

        private static string ComplementaryBlank(int length,int numberOfBlanks=0)
        {
            if (numberOfBlanks >= length / 2) return "";
            return " "+ComplementaryBlank(length, ++numberOfBlanks);
        }

        public static void GenerateElements(int level,ref int[][] triangle,int index=0)
        {
            if (level-1 ==0)
            {
                triangle[0] = new int[] { 1 };
                return;
            }
            if (index == 0)
            {
                triangle[level - 1] = new int[level];
                triangle[level - 1][index] = 1;
                GenerateElements(level, ref triangle, index+1);
            }
            else
            if (index == level - 1)
            {
                triangle[level - 1][index] = 1;
                GenerateElements(level - 1, ref triangle, 0);    
            }
            else
            {
                GenerateElements(level, ref triangle, index + 1);
                triangle[level - 1][index] = triangle[level - 2][index - 1] + triangle[level - 2][index];
            }       

        }
        public static void ConvertArrange(int[][] triangle,ref string[][] printable)
        {


        }
        public static int ReturnBiggest(int[][] triangle,int level,int index=0)
        {
            if (index == triangle[level-1].Length/2) return triangle[level-1][index];
            return ReturnBiggest(triangle, level, index + 1);
        }
        public static string MakeString(int number,int charNumber, int k=0)
        {
            string converted = number.ToString();
            if (converted.Length + k == charNumber) return converted;
            if (k % 2 == 0) return " " + MakeString(number, charNumber, k + 1);
            else return MakeString(number, charNumber, k + 1)+ " ";
        }
        static void Main(string[] args)
        {
        }
    }
}
