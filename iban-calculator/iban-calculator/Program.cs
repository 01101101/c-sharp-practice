using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iban_calculator
{
    class Test
    {
        public int[] IbanCheckNumberCalculator(int iban)
        {
            int[] ibanArray = iban.ToString().Select(o => Convert.ToInt32(o)).ToArray();
            //string ibanString = iban.ToString();
            //char[] ibanArray = ibanString.ToCharArray();
            

             for (int i = 0; i <= 13; i++)
             {

                if ((ibanArray[i] % 2) == 0)
                {
                    Console.WriteLine(ibanArray[i] * 2);
                }
                else
                {
                    Console.WriteLine(ibanArray[i] * 1);
                 }
             }
            return ibanArray;
        }

    }

    /*class BBANtoIBAN
    {
        public string Converter(int bban)
        {
            if(bban )
            {

            }
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            //BBANtoIBAN b = new BBANtoIBAN();
            Test t = new Test();
            //string inputParsed = string.Empty;
            //int bban = 0;
            int iban = 0;

            //while (input.Length <= 8)
            Console.WriteLine("Give me a iban-number");
            //input = int.TryParse(Console.ReadLine());
            //inputParsed = input.Replace("-", "");
            bool isNumber = int.TryParse(Console.ReadLine(), out iban);
            //b.Converter(bban);
            Console.WriteLine(t.IbanCheckNumberCalculator(iban));
            Console.ReadLine();

        }
    }
}
