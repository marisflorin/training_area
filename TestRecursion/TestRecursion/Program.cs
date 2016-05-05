using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecursion
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static void Parcurs(ref int[][] jagged, int level, int index)
        {
            if (level - 1 == 0)
            {
                jagged[0] = new int[] { 1 };
                return;
            }

            if (index == 0)
            {
                jagged[level - 1] = new int[level];
                jagged[level - 1][0] = 1;
                Parcurs(ref jagged, level, index+1);
            }
            else
                if (index == level - 1)
            {
                jagged[level-1][index] = 1;
                Parcurs(ref jagged, level-1, 0);
            }
            else
            {
                Parcurs(ref jagged, level, index+1);
                jagged[level-1][index] = 3;
            }
        }
        }
}
