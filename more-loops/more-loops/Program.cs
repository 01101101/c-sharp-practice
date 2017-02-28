using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_loops
{
    class Calculations
    {
        public int MultiplicationTables()
        {
            int numberMultiplied = 1;

            for(int i = 1; i<= 10; i++)
            {
                for(int e = 1; e<= 10; e++)
                {
                    numberMultiplied = e * i;
                    Console.WriteLine("{0} x {1} = {2}", e, i, numberMultiplied);
                }
            }
            return numberMultiplied;
        }
        public string SquareRoot()
        {
            List<double> squareList = new List<double>();
            double squareRoot;
            string squareRootReturn = string.Empty;

            for (int k = 0; k < 11; k++)
            {
                //numberList.Add(k);
                Console.WriteLine("number {0}s square root is {1}",k ,squareRoot = Math.Sqrt(k));
                squareList.Add(squareRoot);
            }
            //squareRootReturn = string.Format("{0}", squareList);
            squareRootReturn = string.Format("All done!");
            return squareRootReturn; 
            /*for (int i = 0; i < 11; i++)
            {
               squareRoot = Math.Sqrt(numberList[i]);
               squareRootReturn = squareRootReturn + string.Format(Console.WriteLine("Number: {0} and the square root of it: {1}", numberList[i], squareRoot);
            }
            return squareRootReturn;*/
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //double[] numberArray = new double[10];
            Calculations c = new Calculations();
            Console.WriteLine(c.SquareRoot());
            Console.WriteLine(c.MultiplicationTables());
            Console.ReadKey();
        }
    }
}
