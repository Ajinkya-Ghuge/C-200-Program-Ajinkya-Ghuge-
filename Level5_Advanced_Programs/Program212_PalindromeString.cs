using System;

class Program212_PalindromeString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        
        if (input == reversed)
            Console.WriteLine($"'{input}' is a Palindrome");
        else
            Console.WriteLine($"'{input}' is NOT a Palindrome");
    }
}