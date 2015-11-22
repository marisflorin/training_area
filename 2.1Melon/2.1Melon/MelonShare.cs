using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1Melon
{
    // Doi prieteni au cumpărat un pepene de X kg, și doresc să îl împartă.Singura lor dorință e ca fiecare să 
    // primească un număr par de kg din pepene.E ok și dacă nu primesc aceeași cantitate.

    // Scrie un program care răspunde cu DA dacă pepenele poate fi împărțit cum își doresc cei doi prieteni, 
    // și cu NU în caz contrar.

   public class MelonShare
    {
        static void Main(string[] args)
        {
        }
      public static string MelonShareable(int Melonweigth)
        {
            // Melonweigth should be entered in kilograms as an integer
            if (((Melonweigth %2 ==0) && (Melonweigth != 2))&&(Melonweigth>0))
            return "Yes";
            return "No";

        } 
    }
}
