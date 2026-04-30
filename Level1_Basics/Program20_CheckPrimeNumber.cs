using System;

namespace CSharpPrograms
{
    public class Program20_CheckPrimeNumber
    {
        public static void Main()
        {
            // Program 20: Check prime number
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool prime = n >= 2;
            for (int i = 2; i <= Math.Sqrt(n) && prime; i++)
            {
                if (n % i == 0) prime = false;
            }
            Console.WriteLine(prime ? "Prime" : "Not Prime");
        }
    }
}

