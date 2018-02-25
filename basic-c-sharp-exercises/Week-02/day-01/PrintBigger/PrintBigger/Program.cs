using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Enter your first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int secondNUmber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNUmber)
            {
                Console.WriteLine("The first number is bigger");
            }
            else if (firstNumber < secondNUmber)
            {
                Console.WriteLine("The second number is bigger");
            }
            else
            {
                Console.WriteLine("They are equal");
            }
        }
    }
}
