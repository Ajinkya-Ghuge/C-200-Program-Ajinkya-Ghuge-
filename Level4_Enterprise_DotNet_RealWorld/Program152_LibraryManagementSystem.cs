using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program152_LibraryManagementSystem
    {
        public static void Run()
        {
            List<Book> books = new List<Book>
            {
                new Book("Clean Code", true),
                new Book("C# in Depth", false)
            };

            Console.WriteLine("Library Management System");
            foreach (Book book in books)
            {
                string status = book.IsAvailable ? "Available" : "Issued";
                Console.WriteLine($"{book.Title} - {status}");
            }
        }

        private record Book(string Title, bool IsAvailable);
    }
}
