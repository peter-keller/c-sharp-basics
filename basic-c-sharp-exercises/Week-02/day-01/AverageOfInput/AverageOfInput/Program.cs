using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Please enter a number");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number");
            int fourth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number");
            int fifth = int.Parse(Console.ReadLine());

            int sum = first + second + third + fourth + fifth;
            double average = sum / 5;

            Console.WriteLine(sum);
            Console.WriteLine(average);

        }
    }
}
