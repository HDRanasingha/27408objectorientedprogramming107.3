using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet6question7
{
    
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the size of the arrays: ");
                int size = int.Parse(Console.ReadLine());

                int[] arr1 = new int[size];
                int[] arr2 = new int[size];
                int[] arr3 = new int[size];

                // Input values for array 1
                Console.WriteLine("Enter values for array 1:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Value " + (i + 1) + ": ");
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                // Input values for array 2
                Console.WriteLine("Enter values for array 2:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Value " + (i + 1) + ": ");
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                // Calculate scalar sum
                int scalarSum = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarSum += arr1[i] + arr2[i];
                }

                // Calculate vector sum
                for (int i = 0; i < size; i++)
                {
                    arr3[i] = arr1[i] + arr2[i];
                }

                // Calculate vector product
                for (int i = 0; i < size; i++)
                {
                    arr3[i] = arr1[i] * arr2[i];
                }

                // Calculate scalar product
                int scalarProduct = 0;
                for (int i = 0; i < size; i++)
                {
                    arr3[i] = arr1[i] * arr2[i];
                    scalarProduct += arr3[i];
                }

                // Display results
                Console.WriteLine("Scalar Sum: " + scalarSum);
                Console.WriteLine("Vector Sum: " + string.Join(" ", arr3));
                Console.WriteLine("Vector Product: " + string.Join(" ", arr3));
                Console.WriteLine("Scalar Product: " + scalarProduct);

                Console.ReadLine();
            }
        }

    }
