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
      public static decimal[] daytimeprices = { 5, 8, 6 };
      public static decimal[] nighttimeprices = { 7, 10, 8 };
      public static decimal TotalTripCost(decimal distance, int time)
        { // Time will be entered as an integer number , for exemple 08:00 will be 0800 or 800
          // Distance must be entered as a positive number representing kilometers
          // The method calculates the price based on the price corresponding to the starting time of the trip


            if (ValidTimeFormat(time) && PositiveDistance(distance))
                return TripCalculator(distance, time);
            return 0;
        }

        private static decimal TripCalculator(decimal distance, int time)
        {
            if (IsShortDistance(distance)) return ShortDistanceCost(distance, time);
            if (IsLongDistance(distance)) return LongDistanceCost(distance, time);
            return MediumDistanceCost(distance, time);

        }

        private static decimal MediumDistanceCost(decimal distance, int time)
        {
            return ReturnPrice(time)[1] * distance;
        }

        private static decimal LongDistanceCost(decimal distance, int time)
        {
            return ReturnPrice(time)[2] * distance;
        }

        private static decimal ShortDistanceCost(decimal distance, int time)
        {
            return ReturnPrice(time)[0] * distance;
        }

        private static decimal[] ReturnPrice(int time)
        {
            return IsDayTime(time) ? daytimeprices : nighttimeprices;
        }

  
        private static bool IsDayTime(int time)
        {
            return (time > 800) && (time < 2100);
        }

        private static bool PositiveDistance(decimal Distance)
        {
            return Distance > 0;
        }

        private static bool ValidTimeFormat(int Time)
        {
            return IsValidHour(Time) && IsValidMinute(Time);
        }

        private static bool IsValidMinute(int Time)
        {
            return (Time % 100 >= 0) && (Time % 100 < 60);
        }

        private static bool IsValidHour(int Time)
        {
            return (Time >= 0) && (Time < 2400);
        }
    private static bool IsShortDistance(decimal distance)
    {
        return  distance<21;
    }
    private static bool IsLongDistance(decimal distance)
    {
        return distance > 60;
    }
    
}
}
