using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet4question1_3_
{
    
    
        class ConvertValues
        {
            public double kilometerTOmeter(double km)
            {
                double m = km * 1000;
                return m;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ConvertValues converter = new ConvertValues();
                Console.Write("Enter a distance in kilometers: ");
                double km = double.Parse(Console.ReadLine());
                double m = converter.kilometerTOmeter(km);
                Console.WriteLine(km + " kilometers is equal to " + m + " meters.");
                Console.ReadLine();
            }
        }
    }
