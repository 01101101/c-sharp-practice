using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    class IbanTools
    {

        public string CalculatingIban(string ibanNumber)
        {   
            ibanNumber = ibanNumber.Replace("-", "").Replace(" ", "");
            string ibanNumber2 = string.Empty;
            char[] bbanArray = ibanNumber.ToCharArray();
            List<char> bbanList = bbanArray.OfType<char>().ToList();

            for (int i = 0; i < bbanList.Count; i++)
            {
                if (bbanList[i] == '4') //you could check the bban number against any amount of bank identifier numbers here it is used as 4 only as testing purposes
                {
                    if (ibanNumber.Length < 14) //checking if the given bban number is the right size if less than 14 then zeroes are added. Zeroes starting point is set by the bank identifier number
                    {
                        for (int j = 7; bbanList.Count < 14; j++) //adding zeroes to the account number to match the needed account number length of 14 chars
                        {
                            bbanList.Insert(j, '0');
                        }
                        ibanNumber = string.Empty; //converting list back to string
                        for (int j = 0; j < bbanList.Count; j++)
                        {
                            ibanNumber = ibanNumber + bbanList[j];
                        }
                        break;
                    }
                }
                else
                {

                    return ibanNumber + " Number doesent have a valid bank identifier number";

                }
            }
            if (ibanNumber.Length == 14)
            {
                ibanNumber2 = ibanNumber + "FI" + "00";
                //Console.WriteLine(ibanNumber);

            }
            else
            {
                
                return "Wrong sized number!";
            }

            
            string countryCode = "FI"; //country code is a variable that is set to FI but it could be a list of country codes

            ibanNumber2 = ibanNumber2.Replace("F", "15").Replace("I", "18");

            
            decimal a = decimal.Parse(ibanNumber);
            a = 98 - (a % 97);
            //string test1 = "this is your number divided: " + a;
            if (a < 10)
            {
                ibanNumber = "FI0" + a + ibanNumber;
            }
            else
            {
                ibanNumber = "FI" + a +  ibanNumber;
            }    
           
            return "This is your IBAN: " + ibanNumber;
        }
    }
}

