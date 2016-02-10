using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_Password_Generator
{
    /*
    Scrie o funcție care generează o parolă de până la X caractere. Funcția oferă ca și opțiuni:

    1.litere mici
    2.litere mari și numărul lor
    3.cifre și numărul lor
    4.simboluri și numărul lor
    5.să nu includă caracterele similare: l, 1, L, o, 0, O
    6.să nu includă caractere abigue: {}[]()/\'"~,;.<>
    */
    public struct Password
    {
        public int passwordLength;
        public bool smallLetters;
        public int numberOfCapitalLetters;
        public int numberOfDigits;
        public int numberOfSymbols;
        public bool exculdeSimilarChar;
        public bool excludeAmbiguousChar;
    }
        public class PasswordGenerator
    {
        static void Main(string[] args) { }

        public static string PasswordBuilder(Password options)
        {
        char[] smallLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] capitalLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] symbols = {'!','"','#','$','%','&','\'','(',')','*','+','-','.','/',':',';', '<', '=', '>', '?', '@','[','\\' ,']' ,'^' ,'_' ,'`', '{', '|', '}', '~'};
        char[] similars = { 'l', '1', 'L', 'o', '0', 'O' };
        char[] ambiguous = { '{', '}', '[', ']', '(', ')', '/', '\\','\'', '"', '~', ',', ';', '.', '<', '>' };
            int pos = 0;
            int k = 0;
            string password = "";
            char[] passwordArray = new char[options.passwordLength];
            Random rnd = new Random();
            for (int i = 0; i < options.numberOfCapitalLetters; i++)
                AddChars(capitalLetters,ref passwordArray, rnd, i,k);
            k += options.numberOfCapitalLetters ;
            for (int i = 0; i < options.numberOfDigits; i++)
            {
                pos = rnd.Next(0, digits.Length-1);
                passwordArray[i+k] = digits[pos];
            }
            k += options.numberOfDigits;
            for (int i = 0; i < options.numberOfSymbols; i++)
            {
                pos = rnd.Next(0, symbols.Length-1);
                passwordArray[i+k] = symbols[pos];
            }
            k += options.numberOfSymbols;
            for (int i = 0; i < options.passwordLength-k; i++)
                AddChars(smallLetters, ref passwordArray, rnd, i,k);
            password = ConvertToString(passwordArray, password);
            return password;
        }

        private static void AddChars(char[] charArray,ref char[] passwordArray, Random rnd, int i,int k)
        {
            int pos;
            {
                pos = rnd.Next(0, charArray.Length - 1);
                passwordArray[i+k] = charArray[pos];
            }
        }

        private static string ConvertToString(char[] passwordArray,string password)
        {
            for (byte i = 0; i < passwordArray.Length; i++)
            {
                password += passwordArray[i];
            }
            return password;
        }
    }
}
