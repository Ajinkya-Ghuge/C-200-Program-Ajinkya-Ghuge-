using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program197_SecureCodingPracticesInCSharp
    {
        public static void Run()
        {
            string userInput = "report.pdf";
            if (userInput.Contains("..", StringComparison.Ordinal))
            {
                Console.WriteLine("Invalid path input detected.");
                return;
            }

            Console.WriteLine("Validated user input.");
            Console.WriteLine("Use parameterized queries, input validation, and secrets management.");
        }
    }
}
