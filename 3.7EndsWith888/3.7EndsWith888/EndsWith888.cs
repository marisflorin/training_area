using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7EndsWith888
{
    // Cub
    // Un om de știință vrea să știe toate numerele al căror cub se termină cu 888. 
    // Ajută-l prin a-i face un program care pentru numărul k, 
    // întoarce al k-lea număr al cărui cub e 888.
    //  Exemplu: dacă k e 1, rezultatul e 192
    public class EndsWith888
    {
        static void Main(string[] args)
        {
        }
        public static double GetNumber(int rootNumber, int endingDigits)
            {

            int rootCount=0;
            double cubeRoot = 0;
            do
            {
                cubeRoot++;
                if (cubeRoot*cubeRoot*cubeRoot % 1000 == endingDigits) rootCount++;               
            } while (rootCount < rootNumber);

            return cubeRoot;
             
            }    
    }
}
