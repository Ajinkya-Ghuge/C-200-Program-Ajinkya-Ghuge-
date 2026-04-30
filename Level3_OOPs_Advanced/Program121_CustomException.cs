using System;

namespace Level3_OOPs_Advanced
{
    public class Program121_CustomException
    {
        public static void Run()
        {
            try
            {
                ValidateAge(15);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above.");
            }
        }

        private class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message)
            {
            }
        }
    }
}
