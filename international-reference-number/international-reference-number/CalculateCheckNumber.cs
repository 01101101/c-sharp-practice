using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_reference_number
{
    class CalculateCheckNumber
    {
        public string CalculateCheck(string number)
        {
            decimal numberNumber = 98 - (decimal.Parse(number) % 97);
            if (numberNumber < 10)
            {
                number = "RF" + "0" + numberNumber + number;
            }
            else
            {
                number = "RF" +  numberNumber + number;
            }
            number = (number.Remove(number.Length-6));
            return number;
        }
    }
}
