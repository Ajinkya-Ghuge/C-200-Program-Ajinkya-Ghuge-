using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program169_RestApiWithJwtAuthentication
    {
        public static void Run()
        {
            string fakeJwt = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            Console.WriteLine("JWT Authentication Demo");
            Console.WriteLine($"Bearer {fakeJwt}");
        }
    }
}
