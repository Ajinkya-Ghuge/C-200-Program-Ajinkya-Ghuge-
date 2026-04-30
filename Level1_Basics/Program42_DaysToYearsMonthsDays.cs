using System;

namespace CSharpPrograms
{
    public class Program42_DaysToYearsMonthsDays
    {
        public static void Main()
        {
            // Program 42: Convert days into years, months, days
            Console.Write("Enter total days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());
            int years = totalDays / 365;
            int rem = totalDays % 365;
            int months = rem / 30;
            int days = rem % 30;
            Console.WriteLine($"Years = {years}, Months = {months}, Days = {days}");
        }
    }
}

