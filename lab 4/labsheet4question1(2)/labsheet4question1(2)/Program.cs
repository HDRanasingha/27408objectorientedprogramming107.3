using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet4question1_2_
{
   
    
        class ConvertValues
        {
            public void kilometerTOmeter(double km)
            {
                double m = km * 1000;
                Console.WriteLine(km + " kilometers is equal to " + m + " meters.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ConvertValues converter = new ConvertValues();
                Console.Write("Enter a distance in kilometers: ");
                double km = double.Parse(Console.ReadLine());
                converter.kilometerTOmeter(km);
                Console.ReadLine();
            }
        }

    }
