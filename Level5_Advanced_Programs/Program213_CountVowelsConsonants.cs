using System;

class Program213_CountVowelsConsonants
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        
        int vowels = 0, consonants = 0;
        
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".IndexOf(c) >= 0)
                    vowels++;
                else
                    consonants++;
            }
        }
        
        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }
}