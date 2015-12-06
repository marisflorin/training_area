using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2Prefix
{
   public class Prefix
    {
        static void Main(string[] args)
        {
        }
        public static string FindPrefix(string string1, string string2)
        {
            string prefix = "";
            int steps = GetShortStringLength(string1, string2);
            int i = 0;
            while (i <= GetShortStringLength(string1,string2) && string1[i]==string2[i]) 
            {
                prefix += string1[i];
                i++;
            }

            return prefix;
        }

        private static int GetShortStringLength(string firststring, string secoundstring)
        {
            int shortestlength = firststring.Length >= secoundstring.Length ? firststring.Length : secoundstring.Length;
            return shortestlength;
        }
    
    }
}
