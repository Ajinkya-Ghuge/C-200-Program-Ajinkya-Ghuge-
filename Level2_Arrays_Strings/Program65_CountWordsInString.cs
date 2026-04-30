using System;

namespace Level2_Arrays_Strings
{
    public class Program65_CountWordsInString
    {
        public static void Main()
        {
            // Program 65: Count words in a string.
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine() ?? "";
            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Word count = {words.Length}");
        }

    }
}
