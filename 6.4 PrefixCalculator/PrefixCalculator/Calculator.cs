using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixCalculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
        }
        public static double PrefixCalculator(string[] input, int index = 0)
        {
            if (input.Length == 1) return Convert.ToInt32(input[0]);
            if (input[index] == "+" || input[index] == "-") return PrefixCalculator(input, ++index);
            double result = Convert.ToInt32(input[index]) + Convert.ToInt32(input[index + 1]);
            input[index + 1] = Convert.ToString(result);
            ShiftToFeft(ref input, index - 1);    
            return PrefixCalculator(input,0) ;
        }
        public static void ShiftToFeft(ref string[] array,int index,int positions=2)
        {
            for (int i=index; i<array.Length-positions; i++)
                array[i] = array[i + 2];
            Array.Resize(ref array, array.Length-2);
        }
    }
}
