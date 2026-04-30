using System;
using System.Text.RegularExpressions;

namespace Level2_Arrays_Strings
{
    public class Program88_ValidatePasswordStrength
    {
        public static void Main()
        {
            // Program 88: Validate password strength.
            Console.Write("Enter password: ");
            string password = Console.ReadLine() ?? "";

            // At least 8 chars, 1 uppercase, 1 lowercase, 1 digit, 1 special char.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,}$";
            bool strong = Regex.IsMatch(password, pattern);
            Console.WriteLine(strong ? "Strong password" : "Weak password");
        }

    }
}
