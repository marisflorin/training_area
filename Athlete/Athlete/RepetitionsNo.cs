using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete
{
// Sportiv

//    Un sportiv a efectuat mai multe runde de pregătire.
//    În prima rundă a efectuat o singură repetiție.
//    În a doua rundă a efectuat două repetiții și tot așa până la runda `N` când a ajuns la `N` repetiții.
//    După care a început să scadă din nou nr de repetiții, cu câte 1/rundă asta până ce a ajuns din nou la o singură repetiție.

//    Ajută-l pe sportiv să calculeze câte repetiții a efectuat în total.
 public  class RepetitionsNo
    {
        static void Main(string[] args)
        {
        }
        public static int TotalRepetitions(int RoundNumber)
        {
            // If RoundNumber is negative there will be no repetitions
            if  (RoundNumber < 0)
            {
                Console.WriteLine("The Round Number should be positive for exemple {0} should be used instead of {1}", RoundNumber * -1, RoundNumber);
                return 0;
            }
            else
            // The increasing set of repetitions complete the decreasing set of repetitions so the total is the square of the round number
            return RoundNumber*RoundNumber;
        }
    }
}
