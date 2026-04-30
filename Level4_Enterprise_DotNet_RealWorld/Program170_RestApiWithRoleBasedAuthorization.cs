using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program170_RestApiWithRoleBasedAuthorization
    {
        public static void Run()
        {
            string userRole = "Admin";
            bool canDelete = userRole == "Admin";

            Console.WriteLine($"Role: {userRole}");
            Console.WriteLine(canDelete ? "Access granted to DELETE endpoint." : "Access denied.");
        }
    }
}
