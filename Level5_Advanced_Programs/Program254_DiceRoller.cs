using System;

class Program254_DiceRoller
{
    static void Main()
    {
        Random rand = new Random();
        
        Console.Write("Press Enter to roll the dice (or 'q' to quit): ");
        while (Console.ReadLine() != "q")
        {
            int dice = rand.Next(1, 7);
            Console.WriteLine($"You rolled: {dice}");
            Console.Write("Roll again (Enter) or quit (q): ");
        }
    }
}