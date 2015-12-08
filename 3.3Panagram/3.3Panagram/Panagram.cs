using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3Panagram
{  // Panagram
   //  Un panagram e o frază care conține toate literele din alfabet(englezesc). 
   //  Scrie un program care determină dacă o frază e o panagram.
   //  Exemplu: The quick brown fox jumps over the lazy dog
    public class Panagram
    {
        static void Main(string[] args)
        {
        }
        public static bool IsPanagram(string phrase)
        {
            ConvertStringToLowerCase(ref phrase);
            string characterstocheck = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < phrase.Length; i++)
            {
                for (int j = 0; j < characterstocheck.Length; j++)
                {
                    if (AreEqualChars(phrase, characterstocheck, i, j))
                    {
                        RemoveCurrentChar(ref characterstocheck, j);
                        break;
                    }
                }
            }
            return characterstocheck == "" ? true : false;
        }

        private static bool AreEqualChars(string phrase, string characterstocheck, int i, int j)
        {
            return phrase[i] == characterstocheck[j];
        }

        private static void ConvertStringToLowerCase(ref string phrase)
        {
            phrase = phrase.ToLower();
        }

        private static void RemoveCurrentChar(ref string panagram, int j)
        {
            panagram = panagram.Remove(j, 1);
         
        }
    }
}