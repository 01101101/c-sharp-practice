using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_number
{
    class FormatNumber
    {
        public void Formatting(string number)
        {
            
            string formattedNumber = string.Empty;
            for (int i = 0; i < number.Length; i++)
            {
                number.TrimStart('0');
                if (i % 5 == 0 && i != 0)
                {
                    formattedNumber = formattedNumber + " " + number[i] ;
                }
                else
                {
                    formattedNumber = formattedNumber + number[i];
                }
                
         
            }
            Console.WriteLine("this is your number: " + formattedNumber);
        }
    }
}
