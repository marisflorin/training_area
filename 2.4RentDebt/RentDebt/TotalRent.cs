using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDebt
{  // Ai de plătit chiria lunară.Dar cu fiecare zi de întârziere trebuie să plătești o penalitate.
   // Dacă ai întârziat:
    // 1-10 zile - plătești o penalitate de 2% din chirie/zi întârzire
    // 11-30 zile - plătești o penalitate de 5% din chirie/zi întârzire    
    // 31-40 zile - plătești o penalitate de 10% din chirie/zi întârzire
    // Dacă ști chiria și numărul de zile de întârziere, calculează suma totală de plată.
  public  class TotalRent
    {
        static void Main()
        {}
        public static double TotalMonthlyRent(double MonthlyRent, int DaysLate)
        {
            if ((DaysLate > 0) && (DaysLate <= 10)) return (MonthlyRent + (MonthlyRent * 0.02) * DaysLate);

            return 0;   
                }
    }
}
