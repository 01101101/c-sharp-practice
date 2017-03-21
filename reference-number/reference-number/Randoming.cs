using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_number
{
    class Randoming
    {
        Random random = new Random();

        public void RandomTest()
        {
            
        }

        public IList<int> SetNumber(int number) //setting iban number manually for testing purposes
        {
            //string iban = "FI540534220184523";

            //string number = "1234567"; //random.Next(100000).ToString();

            char[] charArray = number.ToString().ToCharArray();
            string n = new string(charArray);
             IList<int> numbers = n.Select(p => int.Parse(p.ToString())).ToList();
            /* Array.Reverse(charArray);
             string s = new string(charArray);
             List<string> numbersReversed = s.Select(x => x.ToString()).ToList();*/

            return numbers;
        }
    }
}
