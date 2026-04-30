using System;

class Program255_RandomNamePicker
{
    static void Main()
    {
        string[] names = { "Alice", "Bob", "Charlie", "Diana", "Eve" };
        Random rand = new Random();
        
        Console.WriteLine("Participants: " + string.Join(", ", names));
        Console.WriteLine($"Randomly selected: {names[rand.Next(names.Length)]}");
    }
}