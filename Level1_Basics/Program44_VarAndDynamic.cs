using System;

namespace CSharpPrograms
{
    public class Program44_VarAndDynamic
    {
        public static void Main()
        {
            // Program 44: var and dynamic demonstration
            var text = "Hello"; // var is compile-time typed
            dynamic value = 10; // dynamic is runtime typed
            Console.WriteLine($"var text = {text}");
            Console.WriteLine($"dynamic value = {value}");
            value = "Now string";
            Console.WriteLine($"dynamic changed = {value}");
        }
    }
}

