using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_toss
{
    class TossingCoin
    {
        public string randomToss(int tossAmount)
        {
            Random rnd = new Random();
            int headsCount = 0;
            int tailsCount = 0;
            int flip = 1;
            string tossReturn;
            for (int i = 1; i <= tossAmount; i++)
            {
                flip = rnd.Next(2);

                if(flip == 0)
                {
                    tailsCount = tailsCount + 1;
                }
                else
                {
                    headsCount = headsCount + 1;
                }
            }
            tossReturn = string.Format("The amount of times coin landed on tails {0} and the amount times coin landed on heads {1}", tailsCount, headsCount);
            return tossReturn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> tossAmount = new List<int>();
            TossingCoin t = new TossingCoin();
            int tossAmount;
            bool isNumber = true;

            while (isNumber == true)
            {
                Console.WriteLine("How many times should we flip a coin?");
                isNumber = int.TryParse(Console.ReadLine(), out tossAmount);
                Console.WriteLine(t.randomToss(tossAmount));
                break;
            }
            Console.ReadLine();
            
        }
    }
}
