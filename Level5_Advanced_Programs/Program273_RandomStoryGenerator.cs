using System;

class Program273_RandomStoryGenerator
{
    static void Main()
    {
        string[] characters = { "Alice", "Bob", "Charlie", "Diana" };
        string[] actions = { "found a treasure", "went on an adventure", "discovered a secret" };
        string[] places = { "in a forest", "on an island", "in a castle" };
        
        Random rand = new Random();
        string story = $"{characters[rand.Next(characters.Length)]} {actions[rand.Next(actions.Length)]} {places[rand.Next(places.Length)]}.";
        
        Console.WriteLine(story);
    }
}