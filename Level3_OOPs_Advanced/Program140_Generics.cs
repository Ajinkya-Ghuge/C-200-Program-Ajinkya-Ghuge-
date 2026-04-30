using System;

namespace Level3_OOPs_Advanced
{
    public class Program140_Generics
    {
        public static void Run()
        {
            GenericBox<int> intBox = new GenericBox<int>(100);
            GenericBox<string> stringBox = new GenericBox<string>("C# Generics");

            Console.WriteLine(intBox.Value);
            Console.WriteLine(stringBox.Value);
        }

        private class GenericBox<T>
        {
            public GenericBox(T value)
            {
                Value = value;
            }

            public T Value { get; }
        }
    }
}
