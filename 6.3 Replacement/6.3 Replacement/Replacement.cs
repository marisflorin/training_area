using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3_Replacement
{ /*Înlocuire
Înlocuiește un caracter dintr-un string cu un alt string.
  */
   public class Replacement
    {
        static void Main(string[] args)
        {
        }
        public static string Replace(string initial, string replacement,ref int index, char replaced)
        {
            if (index > initial.Length-1) return "";
            if (initial[index] == replaced)
            {
                index++;
                return replacement + Replace(initial, replacement, ref index, replaced);
            }
            int next =index+1;
            return initial[index] + Replace(initial, replacement, ref next, replaced);
          

        }
    }
}
