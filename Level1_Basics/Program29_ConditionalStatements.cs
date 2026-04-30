using System;

namespace CSharpPrograms
{
    public class Program29_ConditionalStatements
    {
        public static void Main()
        {
            // Program 29: Conditional statements demonstration
            Console.Write("Enter marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 75) Console.WriteLine("Distinction");
            else if (marks >= 60) Console.WriteLine("First Class");
            else if (marks >= 35) Console.WriteLine("Pass");
            else Console.WriteLine("Fail");
        }
    }
}

