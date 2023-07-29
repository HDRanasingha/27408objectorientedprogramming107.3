using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3question4
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a positive integer:");
                int n = int.Parse(Console.ReadLine());

                int sum = CalculateOddNumberSum(n);

                Console.WriteLine($"Sum of odd numbers from 1 to {n}: {sum}");
            Console.ReadLine();
            }

            static int CalculateOddNumberSum(int n)
            {
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                return sum;
            }
        }
    }


    

