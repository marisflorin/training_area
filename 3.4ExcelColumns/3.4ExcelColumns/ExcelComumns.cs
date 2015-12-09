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
            if (columnindex <= 0) return ""; 
            string basechars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int numberofchars = 26;
            string columnname = "";
            while (IsRemainder(columnindex,numberofchars) || columnindex/numberofchars>=1)
            {
                ConvertRemainder(ref columnindex,numberofchars, basechars, ref columnname);
            }
            return columnname;
        }

        private static bool IsRemainder(int columnindex,int numberofchars)
        {
            return columnindex % numberofchars> 0;
        }

        private static void ConvertRemainder(ref int columnindex, int numberofchars, string alphabet, ref string columnname)
        {
            if (IsNoRemainder(columnindex, numberofchars))
            {
                AddCharacter(numberofchars, alphabet, ref columnname);
                columnindex = columnindex / numberofchars - 1;
            }
            else
            {
                AddCharacter(columnindex % numberofchars, alphabet, ref columnname);
                columnindex = columnindex / numberofchars;
            }
        }

        private static bool IsNoRemainder(int columnindex, int numberofchars)
        {
            return columnindex % numberofchars == 0;
        }

        private static void AddCharacter(int alphabetindex, string alphabet, ref string columnname)
        {
            alphabetindex -= 1;
            columnname = alphabet[alphabetindex]+columnname;
        }
    }
}
