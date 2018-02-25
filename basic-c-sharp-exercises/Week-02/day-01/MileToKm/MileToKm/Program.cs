using System;

namespace MileToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Please type in the amount of distance in km");
            int kmAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("The amount you converted to miles is: " + kmAmount * 0.62);

        }
    }
}
