using System;

namespace CSharpPrograms
{
    public class Program35_StarPattern
    {
        public static void Main()
        {
            // Program 35: Star pattern
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}

