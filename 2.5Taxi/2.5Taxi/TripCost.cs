using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5Taxi
{
   //  O firmă de taxi taxează în funcție de numărul de kilometrii în plus are 
   //     tarife diferențiate pentru zi și pentru noapte.
      
        //   Pe timp de zi(între 8:00 și ora 21:00) tarifele sunt:
   //   1-20km - 5 lei / km
   //   21-60km - 4 lei / km dar se taxează dus și întors
   //   peste 60km - 3 lei / km se taxează dus și întors
   
        //   Pe timp de noapte(între ora 21:00 și 8:00) tarifele sunt:
   //   1-20km - 7 lei / km
   //   21-60km - 5 lei / km dar se taxează dus și întors
   //   peste 60km - 4 lei / km se taxează dus și întors
   //   Dacă ști ce distanță trebuie parcursă și ora din zi, calculează tariful.
  public  class TripCost
    {
        static void Main()
        {}
        public static double TotalTripCost(double Distance, double Time)
        {   if ((Time >= 0) && (Time < 2400))
                if ((Time > 800) && (Time < 2100))
                    return Distance * 5;
                else
                    return Distance * 7;  
            return 0;
        }
    }
}
