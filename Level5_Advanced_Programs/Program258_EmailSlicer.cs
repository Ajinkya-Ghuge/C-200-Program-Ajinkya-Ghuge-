using System;

class Program258_EmailSlicer
{
    static void Main()
    {
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        
        int atIndex = email.IndexOf('@');
        string username = email.Substring(0, atIndex);
        string domain = email.Substring(atIndex + 1);
        
        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Domain: {domain}");
    }
}