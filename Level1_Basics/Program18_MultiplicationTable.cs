using System;

namespace CSharpPrograms
{
    public class Program18_MultiplicationTable
    {
        public static void Main()
        {
            // Program 18: Multiplication table
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}

