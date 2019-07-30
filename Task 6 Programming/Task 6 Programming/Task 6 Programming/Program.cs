using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first letter: ");
            string letter1 = Console.ReadLine();

            Console.WriteLine("Please enter the second letter: ");
            string letter2 = Console.ReadLine();

            if (letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
            {
                Console.WriteLine("Please enter the third letter: ");
                string letter3 = Console.ReadLine();

                if (letter1 == letter3)
                    Console.WriteLine("Well done, your word is a Palindrome!");

                else
                    Console.WriteLine("This word is NOT a Palindrome!");
                Console.ReadLine();
            }

            else
                Console.WriteLine("This is not an actual word.");
            Console.ReadLine();

            
        }
    }
}
