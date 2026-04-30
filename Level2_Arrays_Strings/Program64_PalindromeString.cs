using System;

namespace Level2_Arrays_Strings
{
    public class Program64_PalindromeString
    {
        public static void Main()
        {
            // Program 64: Check palindrome string.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine() ?? "";
            string text = input.ToLower().Replace(" ", "");
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            string rev = new string(chars);
            Console.WriteLine(text == rev ? "Palindrome string" : "Not a palindrome string");
        }

    }
}
