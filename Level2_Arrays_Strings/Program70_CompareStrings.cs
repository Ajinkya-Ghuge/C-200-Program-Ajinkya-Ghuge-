using System;

namespace Level2_Arrays_Strings
{
    public class Program70_CompareStrings
    {
        public static void Main()
        {
            // Program 70: Compare strings.
            Console.Write("Enter first string: ");
            string a = Console.ReadLine() ?? "";
            Console.Write("Enter second string: ");
            string b = Console.ReadLine() ?? "";

            int result = string.Compare(a, b, StringComparison.OrdinalIgnoreCase);
            if (result == 0) Console.WriteLine("Strings are equal");
            else if (result < 0) Console.WriteLine("First string is smaller");
            else Console.WriteLine("First string is greater");
        }

    }
}
