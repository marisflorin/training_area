using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_Pascal_Triangle
{
   public class Pascal
    {
        
        public static void GenerateElement(int level,ref int[][] triangle,int index=0)
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
                GenerateElement(level, ref triangle, index+1);
            }
            else
            if (index == level - 1)
            {
                triangle[level - 1][index] = 1;
                GenerateElement(level - 1, ref triangle, 0);    
            }
            else
            {
                GenerateElement(level, ref triangle, index + 1);
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
        static void Main(string[] args)
        {
        }
    }
}
