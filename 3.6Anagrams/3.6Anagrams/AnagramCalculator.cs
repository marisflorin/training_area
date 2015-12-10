using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6Anagrams
{
    //  Anagrame
    // Pentru un cuvânt dat calculează numărul de anagramări posibile.
    // Nu trebuie ca cuvintele rezultate să existe în dicționar. 
    // Anagramările nu trebuie să se repete și nu trebuie generate anagramările, 
    // doar să se calculeze numărul lor.
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

