using System;

class Program251_PasswordGenerator
{
    static void Main()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%";
        Random rand = new Random();
        
        Console.Write("Enter password length: ");
        int len = Convert.ToInt32(Console.ReadLine());
        
        string password = "";
        for (int i = 0; i < len; i++)
        {
            password += chars[rand.Next(chars.Length)];
        }
        
        Console.WriteLine($"Generated password: {password}");
    }
}