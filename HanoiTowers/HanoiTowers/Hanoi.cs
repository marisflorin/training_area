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
        public static ulong MovesNumber(int numberOfDisks)
        {
            if (numberOfDisks == 1) return 1;
            return 2 * MovesNumber(numberOfDisks - 1) + 1;
        }
    }
}
