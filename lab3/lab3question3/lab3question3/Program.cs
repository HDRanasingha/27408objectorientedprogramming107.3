using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3question3
{
    internal class Program
    {
      
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                int sum = SumOfDigits(number);

                Console.WriteLine($"Sum of the digits of the number: {sum}");
            Console.ReadLine();
            }

            static int SumOfDigits(int number)
            {
                int sum = 0;

                // Convert the number to a string to iterate through its digits
                string numberString = number.ToString();

                for (int i = 0; i < numberString.Length; i++)
                {
                    // Parse each digit back to an integer and add it to the sum
                    int digit = int.Parse(numberString[i].ToString());
                    sum += digit;
                }


            return sum;
            }
        
        }
    
    }
 