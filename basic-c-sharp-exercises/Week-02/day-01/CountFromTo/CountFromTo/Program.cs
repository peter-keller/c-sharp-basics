﻿using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.WriteLine("Please enter your first number.");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number.");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine("The second number should be bigger.");
            }
            else
            {
                for (int i = 1; i < (secondNumber - firstNumber + 1); i++)
                {
                    Console.WriteLine(firstNumber + i);
                }
            }
        }
    }
}
