using System;

class Program253_NumberGuessingGame
{
    static void Main()
    {
        Random rand = new Random();
        int target = rand.Next(1, 101);
        int guesses = 0;
        
        Console.WriteLine("Guess a number between 1-100");
        
        while (true)
        {
            Console.Write("Your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            guesses++;
            
            if (guess == target)
            {
                Console.WriteLine($"Correct! You guessed in {guesses} tries");
                break;
            }
            else if (guess < target)
                Console.WriteLine("Higher!");
            else
                Console.WriteLine("Lower!");
        }
    }
}