using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
     /* 
     Calculează recursiv al k-lea număr din șirul Fibonacci.
     Șirul Fibonacii este o serie de numere: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...
     */
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
        }
  
        public static int CalculateFibonacci(int x)
        {

            if (x < 4)
                return 1;
            return CalculateFibonacci(x - 1) + CalculateFibonacci(x - 2);
        }
        
    }
}
