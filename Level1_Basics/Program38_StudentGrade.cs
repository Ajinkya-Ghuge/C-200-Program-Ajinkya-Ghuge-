using System;

namespace CSharpPrograms
{
    public class Program38_StudentGrade
    {
        public static void Main()
        {
            // Program 38: Grade calculation
            Console.Write("Enter marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());
            char grade = marks >= 90 ? 'A' :
                         marks >= 75 ? 'B' :
                         marks >= 60 ? 'C' :
                         marks >= 35 ? 'D' : 'F';
            Console.WriteLine($"Grade = {grade}");
        }
    }
}

