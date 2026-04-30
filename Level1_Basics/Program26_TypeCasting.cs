using System;

namespace CSharpPrograms
{
    public class Program26_TypeCasting
    {
        public static void Main()
        {
            // Program 26: Type casting demonstration
            int intValue = 25;
            double implicitCast = intValue; // Implicit cast
            double doubleValue = 12.89;
            int explicitCast = (int)doubleValue; // Explicit cast
            Console.WriteLine($"Implicit cast: {implicitCast}");
            Console.WriteLine($"Explicit cast: {explicitCast}");
        }
    }
}

