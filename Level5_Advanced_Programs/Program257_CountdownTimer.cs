using System;
using System.Threading;

class Program257_CountdownTimer
{
    static void Main()
    {
        Console.Write("Enter seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        
        while (seconds > 0)
        {
            Console.WriteLine($"Time left: {seconds}s");
            Thread.Sleep(1000);
            seconds--;
        }
        
        Console.WriteLine("Time's up!");
    }
}