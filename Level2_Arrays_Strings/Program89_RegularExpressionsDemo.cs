using System;
using System.Text.RegularExpressions;

namespace Level2_Arrays_Strings
{
    public class Program89_RegularExpressionsDemo
    {
        public static void Main()
        {
            // Program 89: Demonstrate regular expressions.
            Console.Write("Enter a sentence: ");
            string text = Console.ReadLine() ?? "";

            // Find all words starting with capital letters.
            MatchCollection matches = Regex.Matches(text, @"\b[A-Z][a-zA-Z]*\b");
            Console.WriteLine("Words starting with capital letters:");
            foreach (Match m in matches) Console.WriteLine(m.Value);
        }

    }
}
