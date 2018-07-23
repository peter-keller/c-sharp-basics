using System;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList = PutSaturn(planetList);

            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            foreach (var item in planetList)
            {
                Console.Write(item + ", ");
            }

            
            Console.ReadKey();
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
        }

        public static List<string> PutSaturn(List<string> planets)
        {
            planets.Add("Saturn");
            return planets;
        }
    }
}
