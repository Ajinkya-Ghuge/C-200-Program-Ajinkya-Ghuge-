using System;

class Program272_MadLibs
{
    static void Main()
    {
        Console.Write("Enter a noun: ");
        string noun = Console.ReadLine();
        Console.Write("Enter a verb: ");
        string verb = Console.ReadLine();
        Console.Write("Enter an adjective: ");
        string adj = Console.ReadLine();
        
        Console.WriteLine($"\nStory: The {adj} {noun} {verb} all day long!");
    }
}