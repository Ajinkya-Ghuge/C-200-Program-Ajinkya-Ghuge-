using System;
using System.Collections.Generic;

namespace Level3_OOPs_Advanced
{
    public class Program126_Dictionary
    {
        public static void Run()
        {
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 1, "Ajinkya" },
                { 2, "Amit" },
                { 3, "Sneha" }
            };

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key} -> {student.Value}");
            }
        }
    }
}
