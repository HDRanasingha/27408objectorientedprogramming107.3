//calculate values.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet5question3
{

public class CalculateValues
        {
            public int Addition(int num1, int num2)
            {
                return num1 + num2;
            }

            public int Subtraction(int num1, int num2)
            {
                return num1 - num2;
            }

            public int Multiplication(int num1, int num2)
            {
                return num1 * num2;
            }

            public double Division(int num1, int num2)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return 0;
                }

                return (double)num1 / num2;
            }

            public double KilometerToMiles(double kilometers)
            {
                const double milesConversionFactor = 0.621371;
                return kilometers * milesConversionFactor;
            }
        }

    }


