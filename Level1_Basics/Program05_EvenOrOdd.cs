using System;

namespace CSharpPrograms
{
    public class Program05_EvenOrOdd
    {
        public static void Main()
        {
            // Program 5: Even or odd
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
        }
    }
}

