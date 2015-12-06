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
            int i = 0;
            string panagram = "abc";
            do
            {
                int j = 0;
                while (AreMoreChars(phrase, j) && NotFoundCahr(phrase, i, panagram, j))
                    j++;
                if (DidCheckEntireString(phrase, j)) break;
                i++;
            } while (AreMoreChars(panagram,i));

            return i == 3 ? true : false;
        }

        private static bool AreMoreChars(string phrase, int j)
        {
            return j < phrase.Length;
        }

        private static bool NotFoundCahr(string phrase, int i, string panagram, int j)
        {
            return panagram[i] != phrase[j];
        }

        private static bool DidCheckEntireString(string phrase, int j)
        {
            return j == phrase.Length;
        }
    }
}
