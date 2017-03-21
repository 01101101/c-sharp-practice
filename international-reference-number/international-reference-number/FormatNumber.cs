using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_reference_number
{
    class FormatNumber
    {
        public void NumberToPaperVersion(string number)
        {
            char[] numberArray = number.ToCharArray();
            string n = new string(numberArray);
            IList<string> numbers = n.Select(p => p.ToString()).ToList();
            string paperNumber = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (i % 4 == 0 && i != 0)
                {
                    paperNumber += numbers[i] + " ";
                }
                else
                {
                    paperNumber += numbers[i];
                }
            }
            Console.WriteLine("Paper Number: " + paperNumber);
        }

        public void NumberToMachineVersion(string number)
        {
            number = number.Replace(" ", "");

            Console.WriteLine("Machine number: " + number);
        }
    }
}
