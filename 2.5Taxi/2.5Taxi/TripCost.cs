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
        public static double TotalTripCost(double Distance, int Time)
        { // Time will be entered as an integer number , for exemple 08:00 will be 0800 or 800
          // Distance must be entered as a positive number representing kilometers
          // The method calculates the price based on the price corresponding to the starting time of the trip
            if (((Time >= 0) && (Time < 2400)) && ((Time % 100 >= 0) && (Time % 100 < 60)) && (Distance > 0))
                if ((Time > 800) && (Time < 2100))
                {
                    if (Distance < 21) return Distance * 5;
                    if (Distance > 60) return Distance * 2 * 3;
                    return Distance * 2 * 4;
                }
                else
                {
                    if (Distance < 21) return Distance * 7;
                    if (Distance > 60) return Distance * 2 * 4;
                    return Distance * 2 * 5;
                }
            return 0;
        }
    }
}
