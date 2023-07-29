using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet4question2_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area, circumference;
            const double pi = 3.14159;

            Console.Write("Enter the radius of the circle: ");
            radius = double.Parse(Console.ReadLine());

            area = pi * radius * radius;
            circumference = 2 * pi * radius;

            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is: " + circumference);
            Console.ReadLine();
        }
    }
}

