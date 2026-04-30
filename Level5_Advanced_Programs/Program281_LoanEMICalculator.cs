using System;

class Program281_LoanEMICalculator
{
    static void Main()
    {
        Console.Write("Enter loan amount: ");
        double P = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter annual interest rate: ");
        double r = Convert.ToDouble(Console.ReadLine()) / 12 / 100;
        Console.Write("Enter loan tenure (months): ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        double emi = P * r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1);
        Console.WriteLine($"Monthly EMI: ${emi:F2}");
    }
}