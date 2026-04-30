using System;

namespace Level3_OOPs_Advanced
{
    public class Program108_Interfaces
    {
        public static void Run()
        {
            IPrinter printer = new InkjetPrinter();
            printer.Print("Interface example in C#.");
        }

        private interface IPrinter
        {
            void Print(string content);
        }

        private class InkjetPrinter : IPrinter
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }
        }
    }
}
