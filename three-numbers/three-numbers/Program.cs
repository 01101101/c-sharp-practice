using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int number;
            string message = string.Empty;
            for (int i = 3;i > 0;i--)
            {
                
                Console.Write("Number Please: ");
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (!result)
                {
                    message = string.Format("Hello, not a number");
                }
                else
                {
                    numbers.Add(number);
                }
                
             }
            
            numbers.Sort();
            string combinedNumbers = string.Join(", ", numbers);
            Console.WriteLine("Hello, Youre numbers in sorted order lowest to highest: {0}", combinedNumbers);
            Console.ReadKey();
        }
    }
}
