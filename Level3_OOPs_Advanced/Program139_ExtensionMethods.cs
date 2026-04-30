using System;

namespace Level3_OOPs_Advanced
{
    public class Program139_ExtensionMethods
    {
        public static void Run()
        {
            string message = "advanced csharp";
            Console.WriteLine(message.ToTitleCase());
        }
    }

    public static class StringExtensions
    {
        public static string ToTitleCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            string[] parts = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = char.ToUpper(parts[i][0]) + parts[i][1..];
            }

            return string.Join(" ", parts);
        }
    }
}
