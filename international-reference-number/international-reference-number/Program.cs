using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateRefNumber createNumber = new CreateRefNumber();
            CalculateCheckNumber calculate = new CalculateCheckNumber();
            ValidateNumber validate = new ValidateNumber();
            FormatNumber format = new FormatNumber();

            format.NumberToPaperVersion(calculate.CalculateCheck(createNumber.setNumber()));
            format.NumberToMachineVersion(calculate.CalculateCheck(createNumber.setNumber()));
            validate.Validation(validate.LettersToNumbers(validate.MovingStartingLetters(createNumber.setRfNumber())));
            Console.ReadKey();
        }
    }
}
