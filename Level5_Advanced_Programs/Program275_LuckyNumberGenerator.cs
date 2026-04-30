using System;

class Program275_LuckyNumberGenerator
{
    static void Main()
    {
        Random rand = new Random();
        int lucky = rand.Next(1, 100);
        Console.WriteLine($"Your lucky number is: {lucky}!");
    }
}