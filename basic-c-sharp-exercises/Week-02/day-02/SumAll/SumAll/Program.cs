﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
            int[] ai = { 3, 4, 5, 6, 7 };
            int temp = 0;

            foreach (int i in ai)
            {
                temp += i;
            }
            Console.WriteLine(temp);
        }
    }
}
