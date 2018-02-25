using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            Console.WriteLine("Please type in the height of the cuboid");
            double height = int.Parse(Console.ReadLine());

            Console.WriteLine("Please type in the width of the cuboid");
            double width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please type in the length of the cuboid");
            double length = int.Parse(Console.ReadLine());

            Console.WriteLine("Surface Area: " + (height + width + length) * 2);
            Console.WriteLine("Volume: " + (height * width * length));
        }
    }
}
