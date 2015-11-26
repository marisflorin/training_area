using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6Roman_Numbers
{   // Convertește un număr dat, între 1 și 100, în cifre romane.
    // I - 1; V - 5; X - 10; L - 50; C - 100
    //De ex: 4 - IV; 8 - VIII; 9 - IX; 15 - XV; 30 - XXX; 39 - XXXIX 41 - XLI; 45 - XLV; 99 - XCIX
    public class Convertor
    {
        static void Main(string[] args)
        {
        }
        public static string ConvertorUnits(int Number, string Unit, string Five, string Ten)
        {
            string Converted = "";
            if (Number <4) for (int i=1; i <= Number; i++)  { Converted += Unit; }
            if ((Number > 3) && (Number < 9))
            {
                Converted = Five;
                if (Number == 4) Converted = Unit + Converted;
                for (int i = 5; i < Number; i++) { Converted += Unit; }
            }
            if (Number == 9) Converted = Unit+Ten;
            return Converted;
        }
        public static string ConvertedResult(int Number)
        {
            string Converted = "";
            if ((Number > 0) && (Number <= 100))
            {
                Converted += Convertor.ConvertorUnits(Number / 10, "X", "L", "C") + Convertor.ConvertorUnits(Number % 10, "I", "V", "X");
                return Converted;
            }
            return "Number should be between 1 and 100";

        }
    }
}
