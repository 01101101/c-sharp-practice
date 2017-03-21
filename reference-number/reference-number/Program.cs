using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Randoming random = new Randoming();
            CalculatingCheckNumber calculate = new CalculatingCheckNumber();
            FormatNumber format = new FormatNumber();

            //calculate.CalculateCheckNumber(random.SetNumber());
            Console.WriteLine("How many reference numbers do you need?");
            bool isNumber = int.TryParse(Console.ReadLine(), out int input);
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Give me a number");
                isNumber = int.TryParse(Console.ReadLine(), out int number);
                format.Formatting(calculate.CalculateCheckNumber(random.SetNumber(number)));
            }


            Console.ReadKey();
        }
    }
}
