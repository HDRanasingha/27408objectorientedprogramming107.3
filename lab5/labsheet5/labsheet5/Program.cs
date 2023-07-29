using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet5
{
    
    
        class ArrayOperations
        {
            public void FindMinMaxAvgReverse(int[] arr)
            {
                int min = arr[0], max = arr[0], sum = 0;

                // Find minimum and maximum values
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    sum += arr[i];
                }

                // Calculate average value
                double avg = (double)sum / arr.Length;

                // Reverse order of values
                Array.Reverse(arr);

                // Display results
                Console.WriteLine("Minimum value: " + min);
                Console.WriteLine("Maximum value: " + max);
                Console.WriteLine("Average value: " + avg);
                Console.WriteLine("Reverse order of values: " + string.Join(" ", arr));
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int[] arr = new int[10];
                Console.WriteLine("Enter 10 integer values:");

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                ArrayOperations calculator = new ArrayOperations();
                calculator.FindMinMaxAvgReverse(arr);

                Console.ReadLine();
            }
        }
    }


       