using System;
using System.Collections.Generic;

namespace Level2_Arrays_Strings
{
    public class Program66_CharacterFrequencyInString
    {
        public static void Main()
        {
            // Program 66: Character frequency in string.
            Console.Write("Enter a string: ");
            string text = Console.ReadLine() ?? "";
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (freq.ContainsKey(c)) freq[c]++;
                else freq[c] = 1;
            }

            Console.WriteLine("Character frequencies:");
            foreach (var pair in freq)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

    }
}
