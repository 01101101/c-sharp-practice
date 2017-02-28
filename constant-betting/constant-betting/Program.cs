using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constant_betting
{
    class ConstantRow
    {
        public string ConstantLine() //determing if the the result is 1, x ,2
        {
            Random rnd = new Random();
            string matchResult = string.Empty;
            double probabilities;
            string returnLine;

            for (int i = 1; i < 14; i++)
            {
                probabilities = rnd.NextDouble();

                if(probabilities <= 0.4) //homewin
                {
                    matchResult = "1";
                }
                else if ((probabilities > 0.4) && (probabilities <= 0.6)) //draw
                {
                    matchResult = "X";
                }
                else //away win
                {
                    matchResult = "2";
                }
                Console.WriteLine("Row {0}: {1}", i , matchResult);
            }
            return returnLine = "Working";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstantRow c = new ConstantRow();
            c.ConstantLine();
            Console.ReadLine();

        }
    }
}
