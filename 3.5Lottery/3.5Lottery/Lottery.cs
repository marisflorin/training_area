using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5Lottery
{   //Loto 6 din 49
    
    //Vrei să participi la jocul de noroc 6 din 49 cu o singură variantă(simplă).
    //Calculează ce șanse ai să câștigi la categoria I(6 numere)?
    //Calculează ce șanse ai să câștigi la categoria II(5 numere)?
    //Calculează ce șanse ai să câștigi la categoria III(4 numere)?
    //Calculează și ce șanse ai la categoria I la 5 din 40?
public class Lottery
    {
        static void Main(string[] args)
        {
        }
    public static double CalculateChance(int totalnumbers,int pickednumbers,int category=1)
        {
            if (AreValidValues(totalnumbers, pickednumbers, category))
                return ConvertToPercentRounded(totalnumbers, pickednumbers, category);
            return 0;

        }

        private static bool AreValidValues(int totalnumbers, int pickednumbers, int category)
        {
            return totalnumbers > 0 && pickednumbers > 0 && totalnumbers >= pickednumbers && category > 0 && pickednumbers > category;
        }

        private static double ConvertToPercentRounded(int totalnumbers, int pickednumbers,int category)
        {
            return Math.Round(Probability(totalnumbers, pickednumbers,category), 9);
        }

        private static double Probability(int totalnumbers, int pickednumbers,int category)
        {
            return PickedNumCombinations(pickednumbers, category) * RestOfNumCombinations(totalnumbers, pickednumbers, category) / Combinations(totalnumbers, pickednumbers) * 100;
        }

        private static double RestOfNumCombinations(int totalnumbers, int pickednumbers, int category)
        {
            return Combinations(totalnumbers - pickednumbers, category - 1);
        }

        private static double PickedNumCombinations(int pickednumbers, int category)
        {
            return Combinations(pickednumbers, pickednumbers - category + 1);
        }

        private static double Combinations(int n,int k)
        {
            return Factorial(n)/(Factorial(k)*Factorial(n-k));
        }

        private static double Factorial(decimal totalnumbers)
        {
            double f = 1;
            for (int i = 1; i <= totalnumbers; i++)
                f *= i;
            return f;
        }
    }
}
