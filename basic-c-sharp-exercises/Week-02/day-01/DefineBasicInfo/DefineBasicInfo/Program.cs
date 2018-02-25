using System;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean
            string name = "Peter Keller";
            int age = 23;
            double height = 1.74;
            bool married = false;
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("I am " + height + " cm tall.");
            Console.WriteLine("Am I married? " + married + ".");
        }
    }
}
