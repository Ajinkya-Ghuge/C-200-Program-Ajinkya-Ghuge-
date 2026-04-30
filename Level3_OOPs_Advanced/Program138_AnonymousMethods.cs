using System;

namespace Level3_OOPs_Advanced
{
    public class Program138_AnonymousMethods
    {
        private delegate void Greeting(string name);

        public static void Run()
        {
            Greeting greeting = delegate (string name)
            {
                Console.WriteLine($"Hello, {name}");
            };

            greeting("Ajinkya");
        }
    }
}
