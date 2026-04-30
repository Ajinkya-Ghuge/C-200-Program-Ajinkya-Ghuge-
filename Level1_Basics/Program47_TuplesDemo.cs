using System;

namespace CSharpPrograms
{
    public class Program47_TuplesDemo
    {
        public static void Main()
        {
            // Program 47: Tuple demonstration
            (int id, string name, double marks) student = (101, "Neha", 88.5);
            Console.WriteLine($"Id = {student.id}, Name = {student.name}, Marks = {student.marks}");
        }
    }
}

