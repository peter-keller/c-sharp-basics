using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.Write("Please enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorio(inputNumber));
        }

        static int Factorio(int number)
        {
            int result = 1;
            for (int i = 1; i < number + 1; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
