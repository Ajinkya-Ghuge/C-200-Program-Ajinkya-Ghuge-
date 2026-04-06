using System;

namespace Level2_Arrays_Strings
{
    public class Program83_SplitStringIntoWords
    {
        public static void Main()
        {
            // Program 83: Split string into words.
            Console.Write("Enter a sentence: ");
            string text = Console.ReadLine() ?? "";
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Words are:");
            foreach (string word in words) Console.WriteLine(word);
        }

    }
}
