using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_number
{
    class CalculatingCheckNumber
    {
        public string CalculateCheckNumber(IList<int> numbers)
        {

            string numberString = string.Empty;
            for (int i = 0; i<numbers.Count;i++)
            {
                numberString = numberString + numbers[i];
            }
            Console.WriteLine("this is the number:" + numberString);
            if (numbers.Count < 3)
            {
                return "Not enought numbers!";
            }
            else if (numbers.Count > 19)
            {
                return "Too many Numbers";
            }
            else
            {         
            
            int sum = 0;
            int checkNumber = 0;
                int nIndex = 0;
                int numberBlock = 0;
                List<int> listI = new List<int>();
                int[] weightNumbers = {7, 3, 1};
                foreach (var nO in numbers.Reverse())
                {
                    sum += nO * weightNumbers[nIndex % 3];
                    nIndex++;
                    /*  for (int i = numbers.Count; i > 0;)
                      {

                          if (i >= 3)
                          {


                          for (int j = 0;j < 3;j++)
                              {
                                  listI.Add(int.Parse(numbers[i]));
                                  Console.WriteLine(numbers[i]);
                                  i--;
                                  if (listI.Count == 3)
                                  {
                                      numberBlock = (listI[0] * 7) + (listI[1] * 3) + (listI[2] * 1);
                                      break;
                                  }
                                  else if( listI.Count > 0 && numbers.Count == 0)
                                  {
                                      numberBlock = (listI[0] * 7) + (listI[1] * 3) + (listI[2] * 1);
                                      break;
                                  }
                                  else
                                  {
                                      continue;
                                  }
                              }


                          }
                          else if (i == 2)
                          {
                              for (int j = 0; j < 2;j++)
                              {
                                  listI.Add(int.Parse(numbers[i]));
                                  i--;
                              }
                              numberBlock = (listI[0] * 7) + (listI[1] * 3);
                          }
                          else if (i == 1)
                          {
                              for (int j = 0; j < 1; j++)
                              {
                                  listI.Add(int.Parse(numbers[i]));
                                  i--;
                              }
                              numberBlock = (listI[0] * 7);

                          }
                          sum = sum + numberBlock;
                          Console.WriteLine("this is the block: " + numberBlock);
                          listI.Clear();


                      }
                       for (int i = numbers.Count; i--> 0;)
                          {
                              if ((kIndex > i) && numbers[i] != lastNumber)
                              {
                                  sum = sum + (int.Parse(numbers[i]) * 3);
                                  kIndex = 0;
                              }
                              else
                              {

                                  if (kIndex < i && numbers[i] != lastNumber)
                                  {
                                      sum = sum + (int.Parse(numbers[i]) * 1);

                                      kIndex = i + 1;
                              }
                                  else
                                  {
                                      sum = sum + (int.Parse(numbers[i]) * 7);

                                  }

                              }

                          Console.WriteLine(sum);
                      }*/
                }
                checkNumber = (10 - ((sum % 10))%10);
                if (checkNumber == 10)
                {
                    checkNumber = 0;
                    numberString = numberString + checkNumber;
                }
                else
                {
                    numberString = numberString + checkNumber;
                }
                return numberString;
                
            }
        }
    }
}
