using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3question2
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                Console.WriteLine("Vowel Counter");
            


            // Get the input string from the user
            Console.Write("Enter a string: ");
                string inputString = Console.ReadLine();

                // Convert the input string to lowercase to handle both uppercase and lowercase vowels
                string lowercaseInput = inputString.ToLower();

                // Count the vowels in the input string
                int vowelCount = 0;
                foreach (char character in lowercaseInput)
                {
                    if (IsVowel(character))
                    {
                        vowelCount++;
                    }
                }

                // Display the result
                Console.WriteLine($"The number of vowels in the string: {vowelCount}");
            Console.ReadLine();
            }

            // Helper method to check if a character is a vowel
            static bool IsVowel(char c)
            {
                return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            }
        
        }

}


    

