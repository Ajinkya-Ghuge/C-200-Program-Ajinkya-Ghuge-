using System;
using System.Linq;

namespace Level3_OOPs_Advanced
{
    public class Program131_LinqJoin
    {
        public static void Run()
        {
            var students = new[]
            {
                new { Id = 1, Name = "Ajinkya" },
                new { Id = 2, Name = "Amit" }
            };

            var departments = new[]
            {
                new { StudentId = 1, Department = "IT" },
                new { StudentId = 2, Department = "CS" }
            };

            var result = students.Join(
                departments,
                student => student.Id,
                department => department.StudentId,
                (student, department) => new { student.Name, department.Department });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} -> {item.Department}");
            }
        }
    }
}
