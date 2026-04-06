using System;
using System.Text.RegularExpressions;

namespace Level2_Arrays_Strings
{
    public class Program87_ValidateEmailFormat
    {
        public static void Main()
        {
            // Program 87: Validate email format.
            Console.Write("Enter email: ");
            string email = Console.ReadLine() ?? "";
            string pattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            bool isValid = Regex.IsMatch(email, pattern);
            Console.WriteLine(isValid ? "Valid email format" : "Invalid email format");
        }

    }
}
