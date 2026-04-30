using System;

namespace Level3_OOPs_Advanced
{
    public class Program135_MulticastDelegates
    {
        private delegate void Notify();

        public static void Run()
        {
            Notify notifications = ShowEmailNotification;
            notifications += ShowSmsNotification;
            notifications();
        }

        private static void ShowEmailNotification()
        {
            Console.WriteLine("Email notification sent.");
        }

        private static void ShowSmsNotification()
        {
            Console.WriteLine("SMS notification sent.");
        }
    }
}
