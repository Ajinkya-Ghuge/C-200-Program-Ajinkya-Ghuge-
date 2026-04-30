using System;

class Program271_RockPaperScissors
{
    static void Main()
    {
        string[] options = { "Rock", "Paper", "Scissors" };
        Random rand = new Random();
        
        Console.Write("Enter Rock, Paper, or Scissors: ");
        string player = Console.ReadLine();
        string computer = options[rand.Next(3)];
        
        Console.WriteLine($"Computer chose: {computer}");
        
        if (player == computer)
            Console.WriteLine("It's a Draw!");
        else if ((player == "Rock" && computer == "Scissors") ||
                 (player == "Paper" && computer == "Rock") ||
                 (player == "Scissors" && computer == "Paper"))
            Console.WriteLine("You Win!");
        else
            Console.WriteLine("You Lose!");
    }
}