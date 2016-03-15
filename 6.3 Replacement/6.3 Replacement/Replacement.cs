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
        public static string Replace(string initial, string replacement, int index)
        {
            if (initial.Length == index) return initial.Remove(initial.Length - 1) + replacement;
            return Replace(initial.Remove(initial.Length - 1), replacement, index) 
                + initial[initial.Length - 1];

        }
    }
}
