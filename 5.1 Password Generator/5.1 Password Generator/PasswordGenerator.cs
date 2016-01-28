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
 public class PasswordGenerator
    {
        static void Main(string[] args)
        {
        }
        public static void PasswordBuilder(byte passLength, ref string password)
        {
            int pos = 0;
            char r;
            password = "";
            Random rnd = new Random();
            for (byte i=0;i<passLength;i++)
            {
                pos = rnd.Next(0, 26);
                r = (char)('a' + pos);
                password += r;
            }   
        }

    }
}
