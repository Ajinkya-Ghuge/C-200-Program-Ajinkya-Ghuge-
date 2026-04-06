using System;

namespace Level2_Arrays_Strings
{
    public class Program79_NamedArguments
    {
        public static void Main()
        {
            // Program 79: Demonstrate named arguments.
            PrintDetails(name: "Rahul", age: 23, city: "Pune");
            PrintDetails(city: "Mumbai", age: 25, name: "Neha");

            static void PrintDetails(string name, int age, string city)
            {
                Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
            }
        }

    }
}
