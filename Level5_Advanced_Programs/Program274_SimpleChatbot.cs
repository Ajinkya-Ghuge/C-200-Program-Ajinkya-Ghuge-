using System;

class Program274_SimpleChatbot
{
    static void Main()
    {
        Console.WriteLine("Chatbot: Hello! Ask me something (type 'bye' to exit)");
        
        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine().ToLower();
            
            if (input == "bye") break;
            
            if (input.Contains("hello") || input.Contains("hi"))
                Console.WriteLine("Chatbot: Hi there!");
            else if (input.Contains("name"))
                Console.WriteLine("Chatbot: I'm C# Bot!");
            else if (input.Contains("time"))
                Console.WriteLine($"Chatbot: Current time is {DateTime.Now}");
            else
                Console.WriteLine("Chatbot: I don't understand that.");
        }
    }
}