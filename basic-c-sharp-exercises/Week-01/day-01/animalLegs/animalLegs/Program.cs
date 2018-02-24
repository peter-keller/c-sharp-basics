using System;

namespace animalLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("Please type in the number of chickens");
            int chickens = int.Parse(Console.ReadLine());

            Console.WriteLine("Please type in the number of pigs");
            int pigs = int.Parse(Console.ReadLine());

            int animalLegs = (chickens * 2) + (pigs * 4);

            Console.WriteLine("Animal legs: " + animalLegs);

        }
    }
}
