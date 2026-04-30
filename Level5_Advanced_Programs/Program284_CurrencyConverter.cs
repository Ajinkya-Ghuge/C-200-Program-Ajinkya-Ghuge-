using System;

class Program284_CurrencyConverter
{
    static void Main()
    {
        // Static exchange rates (USD to other currencies)
        double[] rates = { 83.0, 0.85, 110.0, 0.73 }; // INR, EUR, JPY, GBP
        string[] currencies = { "INR", "EUR", "JPY", "GBP" };
        
        Console.Write("Enter amount in USD: ");
        double usd = Convert.ToDouble(Console.ReadLine());
        
        for (int i = 0; i < currencies.Length; i++)
        {
            Console.WriteLine($"{usd} USD = {usd * rates[i]:F2} {currencies[i]}");
        }
    }
}