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
            int i = 0;
            if (AreValidStrings(string1, string2))
                while (InsideString(string1, string2, i) && IsPrefixChar(string1, string2, i))
                 {
                    prefix += string1[i];
                    i++;
                 }

            return prefix;
        }

        private static bool AreValidStrings(string string1, string string2)
        {
            return string1 != "" && string2 != "";
        }

        private static bool IsPrefixChar(string string1, string string2, int i)
        {
            return string1[i] == string2[i];
        }

        private static bool InsideString(string string1, string string2, int i)
        {
            return i <= GetShortStringLength(string1, string2);
        }

        private static int GetShortStringLength(string firststring, string secoundstring)
        {
            int shortestlength = firststring.Length >= secoundstring.Length ? firststring.Length : secoundstring.Length;
            return shortestlength;
        }
    
    }
}
