using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Loop
    {
        public string OddAndEven(int input)
        {
            int numberOddEven = 0;
            //List<int> numberOdd = new List<int>();
            //List<int> numberEven = new List<int>();
            int numberOdd = 0;
            int numberEven = 0;
            //int numberEvenSum = 0;
            string combinedOddEven;

            if (input < 0)
            {
                for (int q = 0; q >= input; q--)
                {


                    if ((q % 2) == 0)
                    {
                        //numberEven.Add(numberOddEven);
                        numberEven = numberEven + q;
                    }
                    else
                    {
                        //numberOdd.Add(numberOddEven);
                        numberOdd = numberOdd + q;
                    }

                }
            }
            else
            {
                for (int r = 1; r <= input; r++)
                {


                    if ((r % 2) == 0)
                    {
                        //numberEven.Add(numberOddEven);
                        numberEven = numberEven + r;
                    }
                    else
                    {
                        //numberOdd.Add(numberOddEven);
                        numberOdd = numberOdd + r;
                    }

                }
            }
            /*for(int even = 0;even<= numberEven.Count;even++)
            {
                numberEvenSum = numberEvenSum + even;
            }*/
            
            combinedOddEven = string.Format("Given number {0}. Even numbers sum {1}. Odd numbers sum {2}", input, numberEven, numberOdd);
            return combinedOddEven;
        }
        public int AddNegative(int input)
        {
            int numberNegativeAdded = 0;

            for (int k = 0; k>=input; k--)
            {
                numberNegativeAdded = numberNegativeAdded + k;
            }
            return numberNegativeAdded;
        }
        public int Add(int input)
        {
            int numberAdded = 0;
            for(int j = 1; j<=input;j++)
            {
                numberAdded = numberAdded + j;
            }
            return numberAdded;
        }

        public int Multiply(int input)
        {
            
            int numberMultiplied = 1;

            for(int i = 1;i<=input;i++)
            {
                numberMultiplied = numberMultiplied * i;
            }
            return numberMultiplied;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Loop l = new Loop();
            bool isNumber = true;
            

            while (isNumber == true)
            {
                Console.WriteLine("Give me a number");
                isNumber = int.TryParse(Console.ReadLine(), out input);
                
                    Console.WriteLine(l.AddNegative(input));
                    //Console.WriteLine("ILLEGAL INPUT");
                    

                
                    Console.WriteLine("Your number multiplied {0}: ", l.Multiply(input));
                    Console.WriteLine("Your number added {0}: ", l.Add(input));
                    Console.WriteLine(l.OddAndEven(input));
                    
                
                
                
            }
            
            Console.ReadKey();

        }
    }
}
