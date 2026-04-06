using System;

namespace Level2_Arrays_Strings
{
    public class Program67_RemoveWhitespacesFromString
    {
        public static void Main()
        {
            // Program 67: Remove white spaces from string.
            Console.Write("Enter a string: ");
            string text = Console.ReadLine() ?? "";
            string noSpaces = text.Replace(" ", "");
            Console.WriteLine("After removing spaces: " + noSpaces);
        }

    }
}
