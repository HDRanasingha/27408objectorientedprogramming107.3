using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2ques5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int x;
            int ans;
            
            


            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("enter num");
                num = int.Parse(Console.ReadLine());
                ans = num % 2;

                if (ans == 0)
                {
                    Console.WriteLine("this is even number");

                }
                else
                {
                    Console.WriteLine("this is odd number");
                }



            }
           
           Console.ReadLine();
            
        }
    }
    
}
