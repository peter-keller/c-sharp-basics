﻿using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;

            Console.WriteLine(massInKg / (heightInM * heightInM));
        }
    }
}
