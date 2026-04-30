using System;
using System.Text.Json;

namespace Level3_OOPs_Advanced
{
    public class Program147_SerializationJson
    {
        public static void Run()
        {
            Student student = new Student { Id = 1, Name = "Ajinkya" };
            string json = JsonSerializer.Serialize(student);
            Console.WriteLine(json);

            Student? deserializedStudent = JsonSerializer.Deserialize<Student>(json);
            Console.WriteLine($"Deserialized Name: {deserializedStudent?.Name}");
        }

        private class Student
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }
    }
}
