using System;

class Program276_JokeGenerator
{
    static void Main()
    {
        string[] jokes = {
            "Why do programmers prefer dark mode? Because light attracts bugs!",
            "Why did the developer go broke? Because he used up all his cache!",
            "How many programmers does it take to change a light bulb? None, it's a hardware problem!",
            "Why do Java developers wear glasses? Because they don't C#!"
        };
        
        Random rand = new Random();
        Console.WriteLine(jokes[rand.Next(jokes.Length)]);
    }
}