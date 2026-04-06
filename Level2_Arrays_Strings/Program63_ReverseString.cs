using System;

namespace Level2_Arrays_Strings
{
    public class Program63_ReverseString
    {
        public static void Main()
        {
            // Program 63: Reverse a string.
            Console.Write("Enter a string: ");
            string text = Console.ReadLine() ?? "";
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine("Reversed string: " + new string(chars));
        }

    }
}
