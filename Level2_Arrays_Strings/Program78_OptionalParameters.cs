using System;

namespace Level2_Arrays_Strings
{
    public class Program78_OptionalParameters
    {
        public static void Main()
        {
            // Program 78: Demonstrate optional parameters.
            Greet("Ajinkya");
            Greet("Ajinkya", "Good Evening");

            static void Greet(string name, string message = "Good Morning")
            {
                Console.WriteLine($"{message}, {name}");
            }
        }

    }
}
