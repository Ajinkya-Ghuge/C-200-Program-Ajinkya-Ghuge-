using System;

class Program259_UsernameGenerator
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine().ToLower().Replace(" ", "");
        
        Random rand = new Random();
        string username = name + rand.Next(100, 999);
        
        Console.WriteLine($"Generated username: {username}");
    }
}