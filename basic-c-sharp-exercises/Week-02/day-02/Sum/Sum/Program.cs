using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `summ` that sum all the numbers
            //   until the given parameter and returns with an integer

            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Summ(number));

        }

        static int Summ(int number)
        {
            int result = 0;
            for (int i = 0; i < number + 1; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
