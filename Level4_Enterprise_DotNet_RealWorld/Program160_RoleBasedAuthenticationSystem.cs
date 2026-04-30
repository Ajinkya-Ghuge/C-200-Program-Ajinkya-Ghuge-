using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program160_RoleBasedAuthenticationSystem
    {
        public static void Run()
        {
            User user = new User("Ajinkya", "Admin");
            Dictionary<string, string[]> permissions = new Dictionary<string, string[]>
            {
                ["Admin"] = new[] { "Create", "Read", "Update", "Delete" },
                ["Viewer"] = new[] { "Read" }
            };

            Console.WriteLine($"User: {user.Username}");
            Console.WriteLine($"Role: {user.Role}");
            Console.WriteLine($"Permissions: {string.Join(", ", permissions[user.Role])}");
        }

        private record User(string Username, string Role);
    }
}
