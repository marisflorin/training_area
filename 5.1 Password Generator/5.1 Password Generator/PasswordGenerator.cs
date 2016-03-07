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
    public struct Interval
    {
        public int begining,end;
        public Interval (int begining,int end)
        {
            this.begining = begining;
            this.end = end;
        }
    }
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
            Interval totalChars = new Interval(33, 126);
            Interval smallLetterss = new Interval(97, 122);
            Interval capitalLetters = new Interval(65, 90);
            Interval digits = new Interval(48, 57);
            /*
            char[] smallLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] capitalLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] symbols = {'!','"','#','$','%','&','\'','(',')','*','+','-','.','/',':',';', '<', '=', '>', '?', '@','[','\\' ,']' ,'^' ,'_' ,'`', '{', '|', '}', '~'};
            char[] similars = { 'l', '1', 'L', 'o', '0', 'O' };
            char[] ambiguous = { '{', '}', '[', ']', '(', ')', '/', '\\','\'', '"', '~', ',', ';', '.', '<', '>' };

                    if (options.exculdeSimilarChar)
                {
                    DeleteExceptions(similars,ref smallLetters);
                    DeleteExceptions(similars,ref capitalLetters);
                    DeleteExceptions(similars,ref digits);
                    DeleteExceptions(similars,ref symbols);
                }

                if (options.excludeAmbiguousChar)
                {
                    DeleteExceptions(ambiguous, ref symbols);
                    DeleteExceptions(ambiguous, ref smallLetters);
                    DeleteExceptions(ambiguous, ref capitalLetters);
                    DeleteExceptions(ambiguous, ref digits);
                    DeleteExceptions(ambiguous, ref symbols);
                }
                */

            //int k = 0;
            string password = "";
            string exceptions = "";
            string symbols = "";
            if (options.exculdeSimilarChar) exceptions += "l1Lo0O";
            if (options.excludeAmbiguousChar) exceptions += "{}[]()/\'\"~,;.<>";
            int numberOfSmallLetters = options.passwordLength - options.numberOfCapitalLetters -
                options.numberOfDigits - options.numberOfSymbols;

            Random rnd = new Random();
            password += GetString(capitalLetters, options.numberOfCapitalLetters, rnd,exceptions) +
                GetString(digits, options.numberOfDigits, rnd,exceptions)+GetString(smallLetterss,numberOfSmallLetters,rnd,exceptions);
            symbols = GenerateString(totalChars);
            exceptions += GenerateString(smallLetterss) + GenerateString(capitalLetters) + GenerateString(digits);
            password += GetString(totalChars, options.numberOfSymbols, rnd, exceptions);

            // password = RandomizeToString(ref passwordArray, password, rnd);

            return password;
        }
    
      
        private static string GetString(Interval acceptedInterval, int numberOfChars, Random rnd, string exceptions)
        {
            int k = 0;
            int c;
            string addedChars = "";
            while (k < numberOfChars) 
            {
                c = rnd.Next(acceptedInterval.begining, acceptedInterval.end);
                if (NotException(c, exceptions))
                    {
                    addedChars = addedChars + (char)(c);
                    k++;
                    }
            };

            return addedChars;

        }
        private static bool NotException(int c, string exceptions)
            {
            bool notException = true;
            for (int i = 0; i < exceptions.Length; i++)
                if (exceptions[i] == (char)c) notException=false;
            return notException;
            }
        public static string GenerateString(Interval stringLimits)
        {
            string generated="";
            for (int i = stringLimits.begining; i <= stringLimits.end; i++)
                generated += (char)(i);
            return generated;
        }


        private static string RandomizeToString(ref char[] passwordArray,string password,Random rnd)
        {
            int pos;
            while (passwordArray.Length > 0)
            {
                pos = rnd.Next(0, passwordArray.Length - 1);
                password += passwordArray[pos];
                ShiftOneToLeft(ref passwordArray, pos);
            }
            return password;
        }

        private static void ShiftOneToLeft(ref char[] passwordArray, int pos)
        {
            for (int i = pos; i < passwordArray.Length - 1; i++)
                passwordArray[i] = passwordArray[i + 1];
            Array.Resize(ref passwordArray, passwordArray.Length - 1);
        }
        public static bool CheckOnlySmallLetters(string password, string ssmallLetters)
        {
            bool foundChar=false;
            for (int i = 0; i < password.Length; i++)
            {
                foundChar = false;
                for (int j = 0; j < ssmallLetters.Length; j++)
                {
                    if (password[i] == ssmallLetters[j]) foundChar = true;
                }
                if (!foundChar) break;
            }
            return foundChar;
        }
        public static bool CheckNotExistence(string passwordToCheck, string searchedChars)
        {
            bool notFound = true;
            for (int i = 0; i < passwordToCheck.Length; i++)
            {
                for (int j = 0; j < searchedChars.Length; j++)
                    if (passwordToCheck[i] == searchedChars[j])
                    {
                        notFound = false;
                        break;
                    }
                if (!notFound) break;
            }
            return notFound;
        }
        public static int Counter(string password,string countedChars)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < countedChars.Length; j++)
                    if (password[i] == countedChars[j]) count++;
            }
            return count;
        }
    }
}
