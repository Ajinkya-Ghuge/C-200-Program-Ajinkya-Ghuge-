using System;

namespace CSharpPrograms
{
    public class Program27_ConstantsAndReadonly
    {
        // const value is fixed at compile time.
        private const double Pi = 3.14159;

        // readonly value can be assigned only at declaration/constructor.
        private readonly string appName = "CSharp Console Demo";

        public static void Main()
        {
            // Program 27: Constants and readonly demonstration
            Program27_ConstantsAndReadonly demo = new Program27_ConstantsAndReadonly();
            Console.WriteLine($"PI constant = {Pi}");
            Console.WriteLine($"Readonly app name = {demo.appName}");
        }
    }
}

