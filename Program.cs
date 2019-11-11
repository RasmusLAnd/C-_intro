using System;

namespace C__intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.assignment

            string input;

            Console.WriteLine("What is your name?");

            input = Console.ReadLine();

            Console.WriteLine($"Hello {input}");

            Console.ReadKey();


            // 2.assignment
            string firstName, surName;

            Console.WriteLine("What is your first name?");

            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");

            surName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {surName}");

            Console.ReadKey();


             // 3.assignment

            string numberOne, numberTwo;

            Console.WriteLine("What is the full name of person#1?");

            numberOne = Console.ReadLine();

            Console.WriteLine("What is the full name of person#2?");

            numberTwo = Console.ReadLine();

            Console.WriteLine($"Two pepole came walking down the street - the first was {numberOne} and the second was {numberTwo}");

            Console.ReadKey();
            
        }
    }
}
