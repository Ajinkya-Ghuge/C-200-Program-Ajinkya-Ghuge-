using System;

class Program260_RandomQuoteGenerator
{
    static void Main()
    {
        string[] quotes = {
            "The only way to do great work is to love what you do.",
            "Life is what happens when you're busy making other plans.",
            "The future belongs to those who believe in the beauty of their dreams.",
            "It is during our darkest moments that we must focus to see the light."
        };
        
        Random rand = new Random();
        Console.WriteLine(quotes[rand.Next(quotes.Length)]);
    }
}