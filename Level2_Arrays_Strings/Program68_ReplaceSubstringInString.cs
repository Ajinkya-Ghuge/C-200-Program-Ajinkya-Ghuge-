using System;

namespace Level2_Arrays_Strings
{
    public class Program68_ReplaceSubstringInString
    {
        public static void Main()
        {
            // Program 68: Replace substring in string.
            Console.Write("Enter original string: ");
            string text = Console.ReadLine() ?? "";
            Console.Write("Enter old substring: ");
            string oldValue = Console.ReadLine() ?? "";
            Console.Write("Enter new substring: ");
            string newValue = Console.ReadLine() ?? "";
            Console.WriteLine("Result: " + text.Replace(oldValue, newValue));
        }

    }
}
