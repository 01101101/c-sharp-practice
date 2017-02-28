using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_test
{
    class RandomCalculations
    {
        private Random rnd = new Random();

        public string RandomingNumbers()
        {
            string randomingNumbersReturn;
            for(int i = 1; i<= 5; i++)
            {
               
                Console.Write("rivi {0}: ", i);
                for(int k = 1; k<= 5; k++)
                {
                    var row = rnd.Next(50);
                    Console.Write("{0} ", row);
                }
                Console.WriteLine("");
            }
            return randomingNumbersReturn = string.Format("Working as intended");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomCalculations r = new RandomCalculations();
            r.RandomingNumbers();
            Console.ReadLine();
        }
    }
}
