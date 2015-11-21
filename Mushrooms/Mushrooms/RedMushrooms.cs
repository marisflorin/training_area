using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms
{
    //## Ciuperci
    // După ploaie au răsărit `N` ciuperci, unele roșii iar altele albe cele roșii îs de X ori mai multe.
    // Câte ciuperci roșii sunt?
    public class RedMushrooms
    {
        static void Main(string[] args)
        {
        }
        public static double RedMushroomNo(int TotalMushrooms, double MushroomRatio)
        {
            // MushroomRatio is the ratio between red mushrooms and white mushrooms
            double RedMushrooms = MushroomRatio * (TotalMushrooms / (1 + MushroomRatio));
            if (RedMushrooms - Math.Truncate(RedMushrooms) == 0)
                return RedMushrooms;
            else {
                Console.WriteLine("The given ratio is not exact and the number of mushrooms was adjusted from the value of {0}",RedMushrooms);
                return Math.Truncate(RedMushrooms);
            }
        }
    }

}
