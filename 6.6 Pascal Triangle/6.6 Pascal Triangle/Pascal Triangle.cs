using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_Pascal_Triangle
{
   public class Pascal
    {
        
        public static void GenerateElement(int level,ref int[][] triangle,int index)
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
        static void Main(string[] args)
        {
        }
    }
}
