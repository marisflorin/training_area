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
        
            string panagram = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < phrase.Length; i++)
            {
                for (int j = 0; j < panagram.Length; j++)
                {
                    if (phrase[i] == panagram[j])
                    {
                        RemoveCurrentChar(ref panagram, j);
                        break;
                    }
                }
            }
            return panagram == "" ? true : false;
        }

        private static void RemoveCurrentChar(ref string panagram, int j)
        {
            panagram = panagram.Remove(j, 1);
        }
    }
}