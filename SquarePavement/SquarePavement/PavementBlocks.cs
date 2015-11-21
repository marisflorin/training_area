using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarePavement
{
//   Pavaj pentru piață
//   Primăria a decis să paveze piața mare din centru orașului cu piatră cubică.
//   Piața e un dreptunghi de `m x n`, iar piatra cubică are dimensiunea de `a x a`.
//   De câte bucăți de piatră e nevoie pentru a acoperi piața?
//   Piatra cubică se vinde la bucată, deci nu pot fi cumpărate jumătăți

//   Exemplu: dacă piața e de 6x6 și piatra cubică e de 4x4, rezultatul trebuie să fie 4
   public class PavementBlocks
    {
        static void Main(string[] args)
        {
        }
        public static int BlockNumber(int SquareLength, int SquareWidth, double BlockSize)
        {
            // SquareLength and SquareWidth are the dimenssions of the square in meters
            // Blocksize is the lenth of the sides of a paving block in centimeters
            double BlocksLength = SquareLength*100 / BlockSize;
            double BlocksWidth = SquareWidth*100 / BlockSize;          
            int BlockNumber=Convert.ToInt32((Math.Ceiling(BlocksLength))*(Math.Ceiling(BlocksWidth)));
            return BlockNumber;
        }
    }
}
