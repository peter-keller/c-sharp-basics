using System;
using System.Collections.Generic;


namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list));
            Console.ReadKey();
        }
        public static bool CheckNums(List<int> container)
        {
            bool contains = container.Contains(4) && container.Contains(8) &&
                            container.Contains(12) && container.Contains(16);

            return contains;
        }
    }
}
