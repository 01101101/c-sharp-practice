using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_price
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int number = 0;
            double price;
            string message = string.Empty;
            Console.Write("Select your data: \n Your age is 7 under press 1: \n Your age is 65 or over press 2: \n Your age is 7-15 press 3: \n You are member of Mtk press 4: \n You are in the army press 5: \n You are a student press 6: \n If none of the above press 7: ");
            bool result = int.TryParse(Console.ReadLine(), out number);
            
            if (!result)
            {
                message = "Please give me a number";
            }
            else if (number < 7)
            {
                switch(number)
                {
                    case 1:
                        price = 0;
                        message = string.Format("Your price is {0} euros", price);
                        break;
                    case 2:
                        price = 16-(16 * 0.5);
                        message = string.Format("Your price is {0} euros", price);
                        break;
                    case 3:
                        price = 16 - (16 * 0.5);
                        message = string.Format("Your price is {0} euros", price);
                        break;
                    case 4:
                        price = 16 - (16 * 0.15);
                        message = string.Format("Your price is {0} euros", price);
                        break;
                    case 5:
                        price = 16 - (16 * 0.5);
                        message = string.Format("Your price is {0} euros", price);
                        break;
                    case 6:
                        string choice;
                        Console.WriteLine("Are you a member of Mtj? Y/N: ");
                        choice = Console.ReadLine();
                        string lower = choice.ToLower();
                        if (lower == "y")
                        {
                            price = 16 - (16 * 0.45 + 16 * 0.15);
                            message = string.Format("Your price is {0} euros", price);
                        }
                        else if (lower == "n")
                        {
                            price = 16 - (16 * 0.45);
                            message = string.Format("Your price is {0} euros", price);
                        }
                        else
                        {
                            message = string.Format("Please give Y or N");
                        }
                        break;
                }
            }
            else
            {
                price = 16;
                message = string.Format("Your price is {0} euros", price);
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }

    }
}
