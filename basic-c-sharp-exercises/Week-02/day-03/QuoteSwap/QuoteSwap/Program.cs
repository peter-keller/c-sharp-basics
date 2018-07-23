using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            foreach (var item in QuoteSwap(list))
            {
                Console.Write(item + " ");
            }


            // Also, print the sentence to the output with spaces in between.
            // Expected output: "What I cannot create I do not understand." 
            Console.ReadKey();
        }

        public static List<string> QuoteSwap(List<string> container)
        {
            string temp = container[5];
            container[5] = container[2];
            container[2] = temp;

            return container;
        }

    }
}
