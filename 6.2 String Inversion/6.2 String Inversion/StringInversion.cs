using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_String_Inversion
{
   public class StringInversion
    {
        static void Main(string[] args)
        {
        }
    public static string Invert(string s)
        {
            if (s.Length == 1) return s;
            return s[s.Length - 1] + Invert(s.Remove(s.Length - 1));
        }
    }
}
