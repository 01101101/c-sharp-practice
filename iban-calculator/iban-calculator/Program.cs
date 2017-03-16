using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program randomizes the checked account number so the test environment is very controlled. No user interference allowed!

namespace iban_calculator
{


    class Program
    {
        static void Main(string[] args)
        {
            BbanTools bT = new BbanTools();
            IbanTools iT = new IbanTools();
            string bban = bT.CreateBBan();
            List<string> bankAccounts = new List<string>();
            for (int i = 0; i< 10; i++) //Creating random numbers for testing purposes
            {  
                bankAccounts.Add(bT.CreateBBan());
            }
            
            foreach (var bankAccount in bankAccounts)//Calculating IBAN from BBAN number
            {
                Console.WriteLine(iT.CalculatingIban(bankAccount));
            }

            
            Console.ReadKey();
        }
    }
}
