using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParquetFlooring
{// Parchet

    //  Trebuie pus parchet laminat într-o cameră de `N x M` mp.
    //  Dimensiunea unei plăci de parchet e de `A x B` mp.
    //  Pierderile sunt de 15%.
    //  De cât parchet e nevoie?
    public class FlooringSurface
    {
        static void Main(string[] args)
        {
        }
        public static double SheetsNeeded(double RoomLength, double RoomWidth, double SheetLength, double SheetWidth, double AllowedLosses)
        {
            // RoomLength and RoomWidth should pe entered in meters
            // SheetLenght and SheetWidth are the dimenssions of one sheet in centimeters
            // AllowedLosses is the percentage of losses

            AllowedLosses = AllowedLosses / 100;
            SheetLength /= 100;
            SheetWidth /= 100;
            double SurfaceNeeded = RoomLength * RoomWidth * ++AllowedLosses;
            double SheetSurface = SheetLength * SheetWidth;
            double NumberOfSheets = SurfaceNeeded / SheetSurface;
            return NumberOfSheets;
        }
    }
}
