using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersLand
{
    // Un fermier are un teren pătrat.Pentru a-și extinde suprafața a mai cumpărat o parcelă alăturată.
    // Noua parcelă are acceași lungime și are o lățime de 230m. 
    // Acum fermierul are un teren de 77ha (770.000mp).
    // Ce dimensiune avea inițial terenul?
  public class Dimension
    {
        static void Main(string[] args)
        {
        }
   public static double SideDimension(double FinalSurface,double AddedSideLength )
        {
            // FinalSurface will be entered in Ha and AddedSideLength 
            FinalSurface *= 10000;
           double Delta = AddedSideLength * AddedSideLength +4* FinalSurface;
            if ((((Delta > 0))&&(FinalSurface>=0))&&(AddedSideLength>=0))
            {
                if (((-AddedSideLength - Math.Sqrt(Delta)) / 2) > 0)
                    return ((-AddedSideLength - Math.Sqrt(Delta)) / 2);
                return ((-AddedSideLength + Math.Sqrt(Delta)) / 2);
            }
            return 0;
        }
    }
}
