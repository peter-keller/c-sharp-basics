using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
            Console.WriteLine(Calculate());
            Console.ReadKey();
        }

        public static string Calculate()
        {
            Console.WriteLine("Please enter an operator");
            string operation = Console.ReadLine();
            Console.WriteLine("Please enter your first number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            double secondNumber = double.Parse(Console.ReadLine());

            string result = String.Empty;

            if (operation == "+")
            {
                result = (firstNumber + secondNumber).ToString();
                return result;
            }
            else if (operation == "-")
            {
                result = (firstNumber - secondNumber).ToString();
                return result;
            }
            else if (operation == "*")
            {
                result = (firstNumber * secondNumber).ToString();
                return result;
            }
            else if (operation == "/")
            {
                if (firstNumber == 0 || secondNumber == 0)
                {
                    result = "You can't divide by zero";
                    return result;
                }
                else
                {
                    result = (firstNumber / secondNumber).ToString();
                    return result;
                }
            }
            else if (operation == "%")
            {
                if (firstNumber == 0 || secondNumber == 0)
                {
                    result = "You can't divide by zero";
                    return result;
                }
                else
                {
                    result = (firstNumber % secondNumber).ToString();
                    return result;
                }
            }
            else
            {
                result = "Not valid operator";
                return result;
            }
        }
    }
}
