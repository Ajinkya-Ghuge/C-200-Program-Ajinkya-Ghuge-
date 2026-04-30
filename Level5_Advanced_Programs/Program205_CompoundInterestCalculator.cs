using System;

class Program205_CompoundInterestCalculator
{
    static void Main()
    {
        Console.Write("Enter principal amount: ");
        double P = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rate of interest: ");
        double R = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time (years): ");
        int T = Convert.ToInt32(Console.ReadLine());
        
        double amount = P * Math.Pow(1 + R/100, T);
        double CI = amount - P;
        
        Console.WriteLine($"Compound Interest: {CI:F2}");
        Console.WriteLine($"Total Amount: {amount:F2}");
    }
}