using System;

namespace Level3_OOPs_Advanced
{
    public class Program101_ClassAndObject
    {
        public static void Run()
        {
            Student student = new Student
            {
                Id = 101,
                Name = "Ajinkya"
            };

            student.Display();
        }

        private class Student
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;

            public void Display()
            {
                Console.WriteLine($"Student Id: {Id}");
                Console.WriteLine($"Student Name: {Name}");
            }
        }
    }
}
