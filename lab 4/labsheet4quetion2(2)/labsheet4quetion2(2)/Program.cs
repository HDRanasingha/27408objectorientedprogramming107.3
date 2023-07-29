using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet4quetion2_2_
{
    
    
        class FindValues
        {
            public double findArea(double radius)
            {
                const double pi = 3.14159;
                double area = pi * radius * radius;
                return area;
            }

            public double findCircumference(double radius)
            {
                const double pi = 3.14159;
                double circumference = 2 * pi * radius;
                return circumference;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                FindValues calculator = new FindValues();

                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());

                double area = calculator.findArea(radius);
                double circumference = calculator.findCircumference(radius);

                Console.WriteLine("The area of the circle is: " + area);
                Console.WriteLine("The circumference of the circle is: " + circumference);
                Console.ReadLine();
            }
        }
    }
