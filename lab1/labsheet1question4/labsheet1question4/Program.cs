using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary, taxRate, salaryAfterTax;
            Console.Write("Enter your salary: ");
            salary = double.Parse(Console.ReadLine());
            Console.Write("Enter the tax rate as a decimal: ");
            taxRate = double.Parse(Console.ReadLine());
            salaryAfterTax = salary * (1 - taxRate);
            Console.WriteLine("Your salary after tax is: " + salaryAfterTax);
            Console.ReadLine();
        }
    }
}
