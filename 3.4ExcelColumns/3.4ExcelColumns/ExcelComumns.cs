using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4ExcelColumns
{
    public class ExcelComumns
    {
        static void Main(string[] args)
        {
        }
        public static string ColumnName(int columnindex)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string columnname="";
            columnindex -= 1;
            columnname += alphabet[columnindex];
            return columnname;
        }
    }
}
