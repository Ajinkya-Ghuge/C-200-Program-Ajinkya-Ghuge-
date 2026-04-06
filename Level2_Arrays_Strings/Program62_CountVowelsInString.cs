using System;

namespace Level2_Arrays_Strings
{
    public class Program62_CountVowelsInString
    {
        public static void Main()
        {
            // Program 62: Count vowels in a string.
            Console.Write("Enter a string: ");
            string text = Console.ReadLine() ?? "";
            int count = 0;
            foreach (char c in text.ToLower())
            {
                if ("aeiou".Contains(c)) count++;
            }
            Console.WriteLine($"Vowel count = {count}");
        }

    }
}
