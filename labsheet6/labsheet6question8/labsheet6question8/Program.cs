using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet6question8
{
    class Animal
    {
        public void AnimalMethod()
        {
            Console.WriteLine("I am an Animal");
        }
    }

    class Dog : Animal
    {
        public void DogMethod()
        {
            Console.WriteLine("I have four legs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.AnimalMethod();
            myDog.DogMethod();

            Console.ReadLine();
        }
    }
}
