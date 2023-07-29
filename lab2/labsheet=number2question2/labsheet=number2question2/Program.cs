using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet_number2question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            string number1;
            number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);

            Console.WriteLine("enter number2");
            string number2;
            number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            int add = num1 + num2;
            Console.WriteLine("adition is" + add);

            int div = num1 / num2;
            Console.WriteLine("divition is" + div);

            int sub = num1 - num2;
            Console.WriteLine("substraction is" + sub);

            int mul = num1 * num2;
            Console.WriteLine("multification is" + mul);


            Console.ReadLine();
        
    }
    }
}
