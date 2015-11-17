using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRate
{
  public  class BankRateCalculator
    {
        // Dobândă bancă descendentă

        //Vrei să iei un credit de 40k euro de la bancă dobânda anuală cerută de bancă e de 7.57%.
        //Creditul e pentru o perioadă de 20 ani contractul prevede restituirea în rate descrescătoare.
        //Calculează ce rată trebuie plătită în luna martie din al celui de al 4-lea an?
        //Generalizează pentru orice sumă, perioadă și dobândă.

        static void Main(string[] args)
        {
        }
        public static double MonthlyBankRate(int LoanValue,int CurrentMonth,int TotalPeriod,double Intrest)
        // TotalPeriod represents the total payment period of the loan in months
        {
            double FixedRate = LoanValue / TotalPeriod;
            double ToBePaid = (TotalPeriod - CurrentMonth + 1) * FixedRate;
            double MonthlyIntrest = ToBePaid* Intrest / (12*100);
           return FixedRate + MonthlyIntrest;
        }
    }
}
