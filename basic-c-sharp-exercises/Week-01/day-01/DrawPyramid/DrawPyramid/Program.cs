using System;

namespace DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.Write("Please enter a number: ");
            int UserInput = int.Parse(Console.ReadLine());


            for (int i = 0; i <= UserInput; i++)
            {
                for (int j = 0; j < UserInput - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
