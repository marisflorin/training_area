using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace HanoiTowers
{   
       public class Hanoi
    {
        public static void Main(string[] args)
        {
        }
        public static void InitializeArrays(int numberOfDisks,ref string[] first,ref string[] aux,ref string[] second)
        {
            ulong numberOfMoves = (ulong)(2 ^ numberOfDisks - 1);
            first = new string[numberOfMoves];
            aux = new string[numberOfMoves];
            second = new string[numberOfMoves];
            for (ulong i=0; i<numberOfMoves;i++ )
            {
                if (i < (ulong)numberOfDisks)
                    first[i] = Convert.ToString(numberOfDisks - (int)i);
                else first[i] = "";
                aux[i] = "";
                second[i] = "";
            }

        }

        public static void GenerateMoves(int numberOfDisks,ref string[] firstTower,ref string[] auxTower,ref string[] secondTower, ref ulong level)
        {

            if (numberOfDisks == 1)
            {
                firstTower[level + 1] = "";
                if (secondTower[level]=="") secondTower[level + 1] =firstTower[level];
                else secondTower[level + 1] = secondTower[level] + " " + firstTower[level];
                level++;
            }
            else
            {
                GenerateMoves(--numberOfDisks, ref firstTower, ref secondTower, ref auxTower, ref level);
                firstTower[level + 1] = "";
                /* cutt one off */
                secondTower[level + 1] = secondTower[level] + " " + firstTower[level];
                level++;
                GenerateMoves(--numberOfDisks, ref auxTower, ref firstTower, ref secondTower, ref level);
            }
        }
    }
}
