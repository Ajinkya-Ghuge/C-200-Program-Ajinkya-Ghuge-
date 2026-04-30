using System;

namespace Level3_OOPs_Advanced
{
    public class Program141_GenericConstraints
    {
        public static void Run()
        {
            Printer<Invoice> printer = new Printer<Invoice>();
            printer.Print(new Invoice());
        }

        private class Printer<T> where T : class, new()
        {
            public void Print(T item)
            {
                Console.WriteLine($"Printed object of type: {item.GetType().Name}");
            }
        }

        private class Invoice
        {
        }
    }
}
