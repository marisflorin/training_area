using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6Anagrams
{
  public  class AnagramCalculator
    {
        static void Main(string[] args)
        {
        }
        public static int CalculateAnagramNum(string anagram)

        {
            return Factorial(anagram.Length)-1;
        }    
            private static int Factorial(int totalletters)
        {
            int f = 1;
            for (int i = 1; i <= totalletters; i++)
                f *= i;
            return f;
        }
        }
    }

