using System;

namespace Level2_Arrays_Strings
{
    public class Program93_StringFormattingDemo
    {
        public static void Main()
        {
            // Program 93: Demonstrate string formatting.
            string name = "Amit";
            int age = 24;
            double salary = 45678.90;

            Console.WriteLine("Name: {0}, Age: {1}, Salary: {2:F2}", name, age, salary);
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary:F2}");
        }

    }
}
