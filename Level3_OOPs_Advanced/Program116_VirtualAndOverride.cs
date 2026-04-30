using System;

namespace Level3_OOPs_Advanced
{
    public class Program116_VirtualAndOverride
    {
        public static void Run()
        {
            Notification notification = new SmsNotification();
            notification.Send();
        }

        private class Notification
        {
            public virtual void Send()
            {
                Console.WriteLine("Sending a generic notification.");
            }
        }

        private class SmsNotification : Notification
        {
            public override void Send()
            {
                Console.WriteLine("Sending an SMS notification.");
            }
        }
    }
}
