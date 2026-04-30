using System;

namespace CSharpPrograms
{
    public class Program41_LeapYear
    {
        public static void Main()
        {
            // Program 41: Leap year check
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool leap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            Console.WriteLine(leap ? "Leap Year" : "Not Leap Year");
        }
    }
}

