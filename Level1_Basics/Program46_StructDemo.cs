using System;

namespace CSharpPrograms
{
    public class Program46_StructDemo
    {
        // Struct declaration at class scope.
        private struct Student
        {
            public int Id;
            public string Name;
        }

        public static void Main()
        {
            // Program 46: Struct demonstration
            Student s;
            s.Id = 1;
            s.Name = "Ajinkya";
            Console.WriteLine($"Id = {s.Id}, Name = {s.Name}");
        }
    }
}

