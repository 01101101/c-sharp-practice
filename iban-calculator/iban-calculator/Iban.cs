using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    class Iban
    {
        private int _lenght;
        private int _countryCode;
        private int _ibanCheckNumber;
        private int _bankIdentifierNumber;
        

        public Iban()
        {
            _bankIdentifierNumber = 405; //
            _countryCode = 1518; //Country code: FI changed to a number acording to the letter to number system
            _ibanCheckNumber = 12;
        }
       /* public int IbanCheckNumberCalculator(int iban)
        {
            char[] iban = iban.ToArray();
            for (int i = 0; i<= 13; i++)
           {
                if(iban[i] % 2 = 0)
                {

                }
                else
                {

                }
           }
        }*/
    }
}

