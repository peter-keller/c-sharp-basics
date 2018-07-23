using System;
using System.Text;


namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            StringBuilder correctTodoText = new StringBuilder(todoText);

            correctTodoText.Insert(0, "My todo:\n")
                           .Append(" - Download games\n     - Diablo");

            
            

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(correctTodoText);

            Console.ReadKey();
        }
    }
}
