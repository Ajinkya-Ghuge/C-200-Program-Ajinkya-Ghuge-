using System;

namespace CSharpPrograms
{
    public class Program02_UserDetails
    {
        public static void Main()
        {
            // Program 2: Display user details
            Console.Write("Enter name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter city: ");
            string city = Console.ReadLine() ?? "";
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }
    }
}

