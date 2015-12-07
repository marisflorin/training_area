using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2Prefix
{
    // Prefix
    // Dacă ai două stringuri, găsește-le prexiul comun.Exemplu: aaab și aaaabbaa au 
    // prefixul comun aaa
   public class Prefix
    {
        static void Main(string[] args)
        {
        }
        public static string FindPrefix(string string1, string string2)
        {
            string prefix = "";
            for (int i=0; i<GetShortStringLength(string1, string2);i++)
                 {
                if (CharNotEqual(string1, string2, i)) break;
                    prefix += string1[i];
                 }

            return prefix;
        }
                
        private static bool CharNotEqual(string string1, string string2, int i)
        {
            return string1[i] != string2[i];
        }
                
        private static int GetShortStringLength(string firststring, string secoundstring)
        {
            int shortestlength = firststring.Length >= secoundstring.Length ? firststring.Length : secoundstring.Length;
            return shortestlength;
        }
    
    }
}
