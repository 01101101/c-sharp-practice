using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum
{
    class Minimi
    {
        public int Numberfy(int number1, int number2)
        {
            int lowest;
            if(number1 <= number2)
            {
                lowest = number1;
            }
            else
            {
                lowest = number2;
            }
            return lowest;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Minimi m = new Minimi();
            string message = string.Empty;
            
            Console.WriteLine("Give me a number");
            bool result1 = int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Give me a another number");
            bool result2 = int.TryParse(Console.ReadLine(), out number2);
            
            if (!result1 || !result2)
            {
                message = "Both inputs need to be a number";
            }
            else
            {
                int lowest = m.Numberfy(number1, number2);
                message = string.Format("The lower number of the two given is: {0}", lowest);
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }

        
    }
}
