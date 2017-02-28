using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_numbers
{
    class Check
    {
        public string NumberCheck()
        {
            int numberhigh = 0;
            int number;
            int listi = 0;
            string highesti = string.Empty;
            List<int> answers = new List<int>();
            

            for(int i = 10;i>0;) //asking 10 inputs and adding them to a list
            {
                Console.WriteLine("Give me a number. You have {0} numbers still to give: ", i);
                bool isNumber = int.TryParse(Console.ReadLine(),out number);
                if(!isNumber)
                {
                    Console.WriteLine("Need a number");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Give me a positive number");
                }
                else
                {

                    answers.Add(number);
                    i--;

                     for (int k = 0;k < answers.Count;k++) //Trying to find the highest number and save the index of it
                     {
                         if(numberhigh <= answers[k]) // comparing iterated list number towards the found highest number
                         {
                             numberhigh = answers[k]; //if true then numberhigh value is set to it
                             listi = k; //saving the index of the highest number
                            //Console.WriteLine("numberhigh {0} and index of it {1}", numberhigh, listi); Just a test printout
                         }

                     } 
                    
                    highesti = string.Format("Here is YOUR highest given number SIR {0} and the index of it {1}", numberhigh.ToString(), listi.ToString());
                }
                
                
            }

            string line = string.Join(",", answers.ToList<int>()) + "," + highesti;
            return line;     
                
                
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Check c = new Check();

            Console.WriteLine("Numbers you gave: {0}",c.NumberCheck());
            Console.ReadKey();
        }
    }
}
