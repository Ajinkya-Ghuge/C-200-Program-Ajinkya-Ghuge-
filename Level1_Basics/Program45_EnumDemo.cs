using System;

namespace CSharpPrograms
{
    public class Program45_EnumDemo
    {
        // Enum declaration at class scope.
        private enum Day
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        public static void Main()
        {
            // Program 45: Enum demonstration
            Day today = Day.Monday;
            Console.WriteLine($"Today = {today}");
            Console.WriteLine($"Numeric value = {(int)today}");
        }
    }
}

