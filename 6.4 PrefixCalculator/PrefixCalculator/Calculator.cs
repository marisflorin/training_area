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
        public static double PrefixCalculator(string elements)
        {

        string[] input = elements.Split(' ');
        int start = 0;
        return Result(input, ref start);  
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
            switch (input[index++])
            {
                case "+":
                    return Result(input, ref index) + Result(input, ref index) ;
                case "-":
                     return Result(input, ref index)- Result(input, ref index) ;
                case "*":
                    return Result(input, ref index)*Result(input, ref index) ;
                case "/":
                    return Result(input, ref index)/Result(input, ref index) ;
            }
            throw new System.ArgumentException("Invalid characters present of invalid input");
        }
        
    }
}
