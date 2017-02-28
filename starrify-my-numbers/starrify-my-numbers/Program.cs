using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starrify_my_numbers
{
    class Stars
    {
        public string Replace(int iNro)
        {
            string star = string.Empty;
                for (; iNro > 0; iNro--)
                {
                    star = star + "*";
                }
            
                return star;
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int iNro;
            string message = string.Empty;
            Stars s = new Stars();
            Console.WriteLine("Type a number please, kind sir");
            bool isNumber = int.TryParse(Console.ReadLine(), out iNro);
            

            if (!isNumber)
            {
                message = "Not a number";
            }
            else
            {
                if(iNro <= 0)
                {
                    message = string.Format("{0} is not a valid number. Give me something over 0", iNro);
                }
                else
                {
                    string star = s.Replace(iNro);
                    message = string.Format("This is your number now: {0}", star);
                }
               
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
