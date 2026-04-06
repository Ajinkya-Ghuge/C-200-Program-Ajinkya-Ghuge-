using System;
using System.Text.RegularExpressions;

namespace Level2_Arrays_Strings
{
    public class Program85_RemoveSpecialCharacters
    {
        public static void Main()
        {
            // Program 85: Remove special characters from string.
            Console.Write("Enter a string: ");
            string text = Console.ReadLine() ?? "";
            string clean = Regex.Replace(text, "[^a-zA-Z0-9 ]", "");
            Console.WriteLine("After removing special characters: " + clean);
        }

    }
}
