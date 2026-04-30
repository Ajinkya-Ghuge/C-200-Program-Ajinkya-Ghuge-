using System;

namespace CSharpPrograms
{
    public class Program14_PalindromeNumber
    {
        public static void Main()
        {
            // Program 14: Check palindrome number
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int original = n, rev = 0;
            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine(original == rev ? "Palindrome" : "Not Palindrome");
        }
    }
}

