using labsheet5question4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet5question4
{
    class SeparateClass
    {
        public void sayHello()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

// Program.cs file


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SeparateClass obj = new SeparateClass();
            obj.sayHello(); // This will work now
            Console.ReadLine();
        }
    }
}
