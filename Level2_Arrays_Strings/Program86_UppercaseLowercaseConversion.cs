using System;

namespace Level2_Arrays_Strings
{
    public class Program86_UppercaseLowercaseConversion
    {
        public static void Main()
        {
            // Program 86: Convert string to uppercase/lowercase.
            Console.Write("Enter a string: ");
            string text = Console.ReadLine() ?? "";
            Console.WriteLine("Uppercase: " + text.ToUpper());
            Console.WriteLine("Lowercase: " + text.ToLower());
        }

    }
}
