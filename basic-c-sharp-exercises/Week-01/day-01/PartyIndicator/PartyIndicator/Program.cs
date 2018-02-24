using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            Console.WriteLine("Number of girls");
            int girlNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of boys");
            int boyNumber = int.Parse(Console.ReadLine());

            if (girlNumber == boyNumber && girlNumber + boyNumber >= 20)
            {
                Console.WriteLine("The party is excellent");
            }
            else if (girlNumber != boyNumber && girlNumber + boyNumber > 20)
            {
                Console.WriteLine("Quite cool party");
            }
            else if (girlNumber + boyNumber < 20)
            {
                Console.WriteLine("Average party");
            }
            else if (girlNumber <= 0)
            {
                Console.WriteLine("Sausage party");
            }
        }
    }
}
