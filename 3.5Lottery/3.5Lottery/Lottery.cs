﻿using System;
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
    public static double CalculateChance(int totalnumbers,int pickednumbers)
        {
            return Factorial(totalnumbers-1);
            
        }

        private static int Factorial(int totalnumbers)
        {
            int f = 0;
            for (int i = 1; i <= totalnumbers; i++)
                f += i;
            return f;
        }
    }
}
