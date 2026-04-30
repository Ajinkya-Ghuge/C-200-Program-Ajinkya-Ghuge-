using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program151_StudentManagementSystem
    {
        public static void Run()
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Ajinkya", "CSE"),
                new Student(2, "Sneha", "IT")
            };

            Console.WriteLine("Student Management System");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id} - {student.Name} - {student.Department}");
            }
        }

        private record Student(int Id, string Name, string Department);
    }
}
