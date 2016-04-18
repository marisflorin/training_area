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
        public static double Result(string[] input, ref int index)
        {
           double result = 0;
            if (index > input.Length) return 0;
            if (double.TryParse(input[index], out result))
            {
                index++;
                return result;
            }
            int next1 = index+1;
            int next2 = index + 2;         
            switch (input[index])
            {
                case "+":
                    return Result(input, ref next1) + Result(input, ref next2) ;
                case "-":
                     return Result(input, ref next1)- Result(input, ref next2) ;
                case "*":
                    return Result(input, ref next1)*Result(input, ref next2) ;
                case "/":
                    return Result(input, ref next1)/Result(input, ref next2) ;
            }
            return 0;
        }
        
    }
}
