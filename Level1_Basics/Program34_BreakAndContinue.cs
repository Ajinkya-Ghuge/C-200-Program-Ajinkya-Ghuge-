using System;

namespace CSharpPrograms
{
    public class Program34_BreakAndContinue
    {
        public static void Main()
        {
            // Program 34: Break and continue demonstration
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) continue; // Skip 5
                if (i == 9) break;    // Stop at 9
                Console.WriteLine(i);
            }
        }
    }
}

