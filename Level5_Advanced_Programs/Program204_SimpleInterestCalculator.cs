using System;

class Program204_SimpleInterestCalculator
{
    static void Main()
    {
        Console.Write("Enter principal amount: ");
        double P = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rate of interest: ");
        double R = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time (years): ");
        double T = Convert.ToDouble(Console.ReadLine());
        
        double SI = (P * R * T) / 100;
        Console.WriteLine($"Simple Interest: {SI}");
        Console.WriteLine($"Total Amount: {P + SI}");
    }
}