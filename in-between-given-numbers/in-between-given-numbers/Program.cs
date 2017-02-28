using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_between_given_numbers
{
    class Check
    {
        public int NumberCheck(int input, int lowest, int highest)
        {
            bool result = false;
            
            
            while(!result)
            {
                Console.WriteLine("Give me a number between {0} and {1}", lowest, highest);
                result = int.TryParse(Console.ReadLine(), out input);
                if(!result)
                {
                    Console.WriteLine("Gimme a number");
                }
                else
                {
                    do
                    {
                        return input;
                    } while ((input >= lowest) && (input <= highest));
                }
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int lowest = 2;
            int highest = 11;
            int input = 0;
            string message = string.Empty;
            Check c = new Check();
            
                Console.WriteLine("Give me a number between {0} and {1}", lowest, highest);
                bool result = int.TryParse(Console.ReadLine(), out input);
                if(!result)
                {
                    message = string.Format("Give me a number");
                }
                else
                {
                    int cnumber1 = c.NumberCheck(input, lowest, highest);
                    message = string.Format("Your number {0} is between {1} and {2}", input, lowest, highest);
                }

             
            
        }
    }
}
