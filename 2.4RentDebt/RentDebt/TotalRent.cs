﻿using System;
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
            if ((41 > DaysLate) && (DaysLate > 0))
            {
                if (DaysLate <= 10) return (MonthlyRent + (MonthlyRent * 0.02) * DaysLate);
                if ((DaysLate > 10) && (DaysLate <= 30)) return (MonthlyRent + (MonthlyRent * 0.05) * DaysLate);
                if (DaysLate > 31)  return (MonthlyRent + (MonthlyRent * 0.1) * DaysLate);
            }
                return 0;  // The method will return 0 for values grather than 40 days as well as for negative values
            
                }
    }
}
