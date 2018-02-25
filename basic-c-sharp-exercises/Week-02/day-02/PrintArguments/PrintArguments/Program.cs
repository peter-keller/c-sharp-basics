using System;

namespace PrintArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourth")
            // ...

            string[] first = { "first" };
            string[] second = { "first", "second" };
            string[] third = { "first", "second", "third", "fourth" };

            Printer(third);

        }

        static void Printer(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }

    }
}
