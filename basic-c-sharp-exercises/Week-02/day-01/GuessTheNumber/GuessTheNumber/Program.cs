using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int number = 8;

            Console.WriteLine("Guess my number");
            int guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("The stored number is lower");
            }
            else if (number > guess)
            {
                Console.WriteLine("The stored number is higher");
            }
            else
            {
                Console.WriteLine("You found the number: " + number);
            }
        }
    }
}
