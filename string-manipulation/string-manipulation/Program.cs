using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_manipulation
{
    class StringManipulation
    {
        public string Manipulation()
        {

            string returnString = string.Empty;
            int vowelCount = 0;
            string vowels = "AEIOUYÄÖ";
            string isPalindrome = string.Empty;
            int length;
            string parsedInput;
            string input = string.Empty;
            int letterCount = 0;
            Console.WriteLine("Write some text please: ");
            input = Console.ReadLine();
            input = input.ToUpper();
            //Console.WriteLine("I HAVE ALTERED YOUR INPUT. PRAY I DO NOT ALTER IT ANY FURTHER: {0}", input);
            length = input.Length;
            //Console.WriteLine("The lenght of the input is: {0}", length);

            parsedInput = input.Replace("E", "@");
            //Console.WriteLine(parsedInput);

            char[] inputChar = input.ToCharArray();
            char[] vowelsChar = vowels.ToCharArray();


            for (int i = 0; i < input.Length; i++)
            {
                if (inputChar[i].ToString() == "L")
                {
                    letterCount = letterCount + 1;
                }
            }
            //Console.WriteLine(letterCount);

            for (int j = 0; j < input.Length; j++)
            {
                isPalindrome = isPalindrome + input[input.Length - j - 1];
            }
            if (isPalindrome == input)
            {
                //Console.WriteLine("Your word is a palindrome");
                isPalindrome = "Your word is a palindrome";
            }
            else
            {
                //Console.WriteLine("Your word is not a palindrome");
                isPalindrome = "Your word is not a palindrome";
            }

            string combined = string.Empty;
            //Console.WriteLine(inputChar);
            for (int k = 0; k < input.Length; k++)
            {
                for (int v = 0; v < vowels.Length; v++)
                {

                    if (inputChar[k] == vowelsChar[v])
                    {

                        //combined = "," + inputChar[k];
                        vowelCount = vowelCount + 1;
                    }
                    /*else
                    {


                        Console.WriteLine("vowelsELSE: " + combined);
                    }*/

                }
            }
            //Console.WriteLine("vowelCount: {0}", vowelCount);
            //Console.WriteLine("Your input is {0} and the amount of vowels it has {1}", input, vowelCount);

            returnString = string.Format("Your word was {0} and {1}. {0} has {2} vowels in it. {0} has {3} letters in it. {4} this is your word a little bit different perhaps.", input, isPalindrome, vowelCount, length, parsedInput);
            return returnString;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringManipulation s = new StringManipulation();
            Console.WriteLine(s.Manipulation());
            Console.ReadKey();
        }
    }
}
