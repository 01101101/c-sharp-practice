using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iban_calculator
{
    class BbanTools
    {
        private Random random = new Random();

        public string CreateBBan() //Creating a bban number randomly
        {
            int yesNoRandom1 = random.Next(1,3);
            int yesNoRandom2 = random.Next(1,3);
            string bbanStart1 = "405"; //one of Aktia Pankki identifier numbers. This is used for testing purposes
            string bbanStart2 = random.Next(1,3).ToString() +""+  random.Next(1,3).ToString();
            string bbanEnd1 = "-";
            string bbanEnd2 = "";
            int bbanEndLength = random.Next(2, 8);
            for (int i = 3; i < 6; i++)
            {
                if (yesNoRandom1 == 2)
                {
                    int number = random.Next(10);
                    bbanStart1 = bbanStart1 + number;
                }
                else
                {
                    int number = random.Next(10);
                    bbanStart2 = bbanStart2 + number;
                    bbanStart1 = "";
                }
                
            }

            for (int i = 0; i<bbanEndLength;i++)
            {
                if (yesNoRandom2 == 2)
                {
                    int number = random.Next(10);
                    bbanEnd1 = bbanEnd1 + number;
                }
                else
                {
                    int number = random.Next(10);
                    bbanEnd2 = bbanEnd2 + number;
                    bbanEnd1 = "";
                }
                

            }
           // Console.WriteLine(bbanStart1 + bbanStart2  + bbanEnd1 + bbanEnd2);
            return bbanStart1 + bbanStart2 + bbanEnd1 + bbanEnd2;
        }

    }
    
}
