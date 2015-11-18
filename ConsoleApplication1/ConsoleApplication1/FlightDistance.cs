using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Două trenuri pornesc în același timp unul către celălalt cu o viteză constantă de `X` km/h.
// Când cele două trenuri sunt la o pătrime din distanța inițială, o pasăre aflată pe primul tren pornește 
// în zbor către al 2-lea tren cu o viteză de 2X.
// Imediat ce a ajuns la el se întoarce către primul și repetă asta până când cele două trenuri se întâlnesc.
// Care e distanța zburată de pasăre?
namespace ConsoleApplication1
{
   public class FlightDistance
    {
        static void Main(string[] args)
        {
        }
        public static double DistanceFlown(double DistBetweenTrains, int Birdspeed, int Trainsspeed)
        {
            // DistBetweenTrains represents the starting distance between the trains in kilometers
            // Birdspeed and Trainsspeed are in km/h
            DistBetweenTrains = DistBetweenTrains / 4;
            double SpeedRatio = Birdspeed / Trainsspeed;
            double BirdDistance = 0;
          
            // Bird will not fly if distance between trains is less than 10m
            while (DistBetweenTrains>0.010)

                {
                double TrainDistance = DistBetweenTrains / (SpeedRatio + 1);
                BirdDistance = BirdDistance+(TrainDistance * SpeedRatio);
                DistBetweenTrains = DistBetweenTrains - 2 * TrainDistance;
               }
            return BirdDistance ;
                }
            }


}
