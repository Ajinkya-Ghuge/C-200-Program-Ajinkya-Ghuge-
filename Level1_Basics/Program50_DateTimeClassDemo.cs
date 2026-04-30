using System;

namespace CSharpPrograms
{
    public class Program50_DateTimeClassDemo
    {
        public static void Main()
        {
            // Program 50: DateTime class demonstration
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");
            Console.WriteLine($"Short Date: {now.ToShortDateString()}");
            Console.WriteLine($"Long Date: {now.ToLongDateString()}");
            Console.WriteLine($"Short Time: {now.ToShortTimeString()}");
            Console.WriteLine($"Day of Week: {now.DayOfWeek}");
            Console.WriteLine($"After 7 days: {now.AddDays(7).ToShortDateString()}");
        }
    }
}

