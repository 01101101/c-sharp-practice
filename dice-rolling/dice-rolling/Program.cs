using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_rolling
{
    class RollTheDice
    {
        public string ActualDiceRolling()
        {
            Random rnd = new Random();
            int sixCount = 0;
            int roll = 1;
            string rollReturn = string.Empty;

            for (int i = 1; i <= 1000; i++)
            {
                roll = rnd.Next(6)+1;
                if(roll == 6)
                {
                    sixCount = sixCount + 1;
                }
                Console.WriteLine("Roll {0} and the rolled number {1}", i , roll);
                
            }
            Console.WriteLine("the amount of sixes: {0}", sixCount);
            rollReturn = string.Format("the amount of sixes: {0}", sixCount);
            return rollReturn;
        }
        
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            RollTheDice r = new RollTheDice();
            r.ActualDiceRolling();
            Console.ReadLine();
        }
    }
}
