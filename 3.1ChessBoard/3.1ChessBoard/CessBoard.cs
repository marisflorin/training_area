using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1ChessBoard
{
    //Pătrate pe tabla de șah
    //Calculează câte pătrate se pot forma pe o tablă de șah de dimensiunea de 8 x 8.

   public class CessBoard
    {
        static void Main(string[] args)
        {}
        public static int NumberOFSquares(int side)
        {
            int totalsquares = 0;
            for (int i=1; i <= side; i++ )
            {
                totalsquares += i * i; 
            }
            return totalsquares;
        }  
    }
}
