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
            ulong Steps = (ulong)Math.Pow(2,numberOfDisks);
            first = new string[Steps];
            aux = new string[Steps];
            second = new string[Steps];
            for (ulong i = 0; i < Steps; i++)
            {
                first[i] = "";
                aux[i] = "";
                second[i] = "";
            }
            first[0] = Convert.ToString(numberOfDisks);
            for (int i = numberOfDisks - 1; i > 0; i--)
            {
                first[0] += " "+i.ToString();
            }

        }

        public static void GenerateMoves(ref int numberOfDisks,ref string[] firstTower,ref string[] auxTower,ref string[] secondTower, ref ulong level)
        {
            if (numberOfDisks < 1) return;
            if (numberOfDisks == 1)
            {
                auxTower[level + 1] = auxTower[level];
                MoveDisk(ref firstTower,ref secondTower, level);
                level++;
                return;
            }
            else
            {
                --numberOfDisks;
                GenerateMoves(ref numberOfDisks, ref firstTower, ref secondTower, ref auxTower, ref level);
                auxTower[level + 1] = auxTower[level];
                MoveDisk(ref firstTower,ref  secondTower, level);
                level++;
                GenerateMoves(ref numberOfDisks, ref auxTower, ref firstTower, ref secondTower, ref level);
            }
        }

        private static void MoveDisk(ref string[] firstTower,ref string[] secondTower, ulong level)
        {
            int disk;
            if (IsSingleDisk(firstTower, level, out disk)) TransferDisk(firstTower, secondTower, level);

            else
            {
                firstTower[level + 1] = firstTower[level].Substring(0, firstTower[level].LastIndexOf(' ')); ;
                TransferDisk(firstTower, secondTower, level);
            }
        }

        private static bool IsSingleDisk(string[] firstTower, ulong level, out int disk)
        {
            return Int32.TryParse(firstTower[level], out disk);
        }

        private static void TransferDisk(string[] firstTower, string[] secondTower, ulong level)
        {
            if (secondTower[level] == "") secondTower[level + 1] = firstTower[level].Substring(firstTower[level].LastIndexOf(' ') + 1);
            else secondTower[level + 1] = secondTower[level] + " " + firstTower[level].Substring(firstTower[level].LastIndexOf(' ') + 1);
        }
    }
}
