using System;
using System.Collections.Generic;

namespace ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsSeven(List));
            Console.WriteLine(ContainsSevenSimple(List));
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!
            Console.ReadKey();
        }

        public static string ContainsSeven(List<int> inputList)
        {
            string temp = String.Empty;
            foreach (var item in inputList)
            {
                if (item == 7)
                {
                    temp = "Hooray";
                }
                else
                {
                    temp = "Noooooo";
                }
            }
            return temp;
        }

        public static string ContainsSevenSimple(List<int> inputList)
        {
            string temp = String.Empty;
            if (inputList.Contains(7))
            {
                return temp = "Hooray";
            }
            else
            {
                return temp = "Nooooo";
            }
        }
    }
}
