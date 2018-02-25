using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Please enter a number.");
            int input = int.Parse(Console.ReadLine());
            string star = "";
            Console.WriteLine("\n");

            for (int i = 1; i < input + 1; i++)
            {
                Console.WriteLine(star += "*");
            }
        }
    }
}
