using System;
using System.Security.Cryptography;
using System.Text;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program189_SecurePasswordHashing
    {
        public static void Run()
        {
            string password = "P@ssw0rd!";
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = SHA256.HashData(Combine(salt, Encoding.UTF8.GetBytes(password)));

            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");
            Console.WriteLine($"Hash: {Convert.ToBase64String(hash)}");
        }

        private static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] result = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, result, 0, first.Length);
            Buffer.BlockCopy(second, 0, result, first.Length, second.Length);
            return result;
        }
    }
}
