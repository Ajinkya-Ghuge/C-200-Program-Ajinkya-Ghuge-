using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program171_ExceptionHandlingMiddleware
    {
        public static void Run()
        {
            try
            {
                ProcessRequest();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Middleware caught exception: {ex.Message}");
            }
        }

        private static void ProcessRequest()
        {
            throw new InvalidOperationException("Unhandled exception from API pipeline.");
        }
    }
}
