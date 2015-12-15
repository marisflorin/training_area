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
           anagram = anagram.ToLower();
            if (ContainsBlank(anagram)) return 0; 
           if (anagram.Length>0)
                return Factorial(anagram.Length)/GetDivisor(anagram);
            return 0;
        }
           private static int GetDivisor(string word)
        {
            int divisor = 1;
            int i = 0;
            while (IsInsideString(word,i))
            {
                int j = i + 1;
                int kount = 1;
                int factorial = 1;
                while (IsInsideString(word, j))
                {
                    if (IsEqualChar(word, i, j))
                    {
                        kount++;
                        factorial = factorial * kount;
                        RemoveCurrentChar(ref word, j);
                    }
                    else j++;
                }
                divisor = divisor * factorial;
                i++;
            }
            return divisor;
        }
        private static bool ContainsBlank(string anagram)
        {
            for (int i = 0; i < anagram.Length; i++)

                if (anagram[i] == " ".ToString()[0])
                return true;
            return false;
        }
        private static bool IsEqualChar(string word, int i, int j)
        {
            return word[i] == word[j];
        }

        private static bool IsInsideString(string word, int j)
        {
            return j < word.Length;
        }

        private static int Factorial(int totalletters)
        {
            int f = 1;
            for (int i = 1; i <= totalletters; i++)
                f *= i;
            return f;
        }
        private static void RemoveCurrentChar(ref string panagram, int j)
        {
            panagram = panagram.Remove(j, 1);

        }
    }
    }

