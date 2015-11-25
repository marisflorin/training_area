using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // Pentru un număr dat dacă e multiplu de 3 rezultatul trebuie să fie Fizz iar dacă e multiplu
    // de 5 rezultatul trebuie să fie Buzz. Dacă e multiplu de 3 și de 5 rezultatul trebuie să fie FizzBuzz.
    public class Fizzbuzz
    {
        static void Main(string[] args)
        {
        }
        public static string Buzzer(double Number)
        {
            if (Number % 3 == 0)
                return "Buzz";
            if (Number % 5 == 0)
                return "Fizz";

                return " ";
        }

    }
}
