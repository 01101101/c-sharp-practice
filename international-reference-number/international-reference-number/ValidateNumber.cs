using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_reference_number
{
    class ValidateNumber
    {
        public string LettersToNumbers(string number) // for testing purposes the letters are RF
        {
            string lettersToNumbers = number.Replace("R", "27").Replace("F", "15");
            return lettersToNumbers;
        }

        public void Validation(string number)
        {
            Console.WriteLine("this is the number: " + number);
           decimal numberInt = decimal.Parse(number) % 97;
           Console.WriteLine("This is whats left: " + numberInt);
        }

        public string MovingStartingLetters(string number)
        {    
           char[] numberArray = number.ToCharArray();
        string n = new string(numberArray);
        IList<string> numbers = n.Select(p => p.ToString()).ToList();

        string startString = string.Empty;

            for (int i = 0; i< 4; i++)
            {
                startString = startString + numbers[i];
               // Console.WriteLine("startstring: " + startString);
            }
            number = number.Remove(0, 4) + startString;
            //Console.WriteLine("UH-OH" + number);
            return number;
        }


    }
}
