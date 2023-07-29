using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace labsheet1question2
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Circle Area Calculator!");
                Console.WriteLine("Please enter the radius of the circle:");

                // Read the radius from the user as a string
                string input = Console.ReadLine();

                // Parse the input string to get the radius as a double
                if (double.TryParse(input, out double radius))
                {
                    // Calculate the area of the circle using the formula: Area = π * r^2
                    double area = Math.PI * Math.Pow(radius, 2);

                    Console.WriteLine($"The area of the circle with radius {radius} is: {area:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }














