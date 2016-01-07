using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1BaseConversion
{ /* Operații în baza doi
  Ai un număr zecimal transformă-l în baza doi, reprezentat ca și un array de byte (byte[]).
  Pentru un număr transformat implementează operațiile:
  NOT, AND, NOT, OR, XOR
  RightHandShift și LeftHandShift(shiftare de biți la dreapta și la stânga)
  LessThan
  Adunare și scădere
  Înmulțire și împărțire
  Folosește-te de LessThan pentru a implementa și alți operatori de comparare(GraterThan, Equal, NotEqual)
  Doar pentru numere pozitive.
  Poți generaliza transformarea și operațiile de la 3-6 pentru o bază aleatoare (baza fiind între 2 și 255)?
  */
   public class BaseConversion
    {
        static void Main(string[] args)
        {
        }
    public static byte[] ConvertToBit(int number)
        {
            byte[] converted = new byte[8];
            int i = 1;
 
            while (number/2!=0 || number%2!=0)
            {
                int position = converted.Length - i;
                if (number % 2 == 1) converted[position] = 1;
                else converted[position] = 0;
                number = number / 2;
                i++;
                
                
            }


            return converted;
        }
      
    }
}

