using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4ExcelColumns
{   // Coloane excel

    // Primele 26 de coloane din Excel sunt marcate cu literele alfabetului.
    // După care continuă cu combinații de câte două litere, astfel coloana 27 este AA, 
    // 28 - AB, iar coloana 52 cu AZ.După ZZ, se continuă cu combinații de 3 litere.
    // Dacă se dă numărul coloanei află care e combinația de litere corespunzătoare.

    public class ExcelComumns
    {
        static void Main(string[] args)
        {
        }
        public static string ColumnName(int columnindex)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string columnname = "";
            if (columnindex/26>0) 
                AddLetter(columnindex/26, alphabet, ref columnname);
            AddLetter(columnindex % 26, alphabet, ref columnname);
            return columnname;
        }

        private static void AddLetter(int alphabetindex, string alphabet, ref string columnname)
        {
            alphabetindex -= 1;
            columnname += alphabet[alphabetindex];
        }
    }
}
