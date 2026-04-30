using System;

namespace Level3_OOPs_Advanced
{
    public class Program118_DependencyInjectionBasic
    {
        public static void Run()
        {
            IMessageService service = new EmailService();
            NotificationManager manager = new NotificationManager(service);
            manager.Send("Dependency injection keeps code flexible.");
        }

        private interface IMessageService
        {
            void SendMessage(string message);
        }

        private class EmailService : IMessageService
        {
            public void SendMessage(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }

        private class NotificationManager
        {
            private readonly IMessageService messageService;

            public NotificationManager(IMessageService messageService)
            {
                this.messageService = messageService;
            }

            public void Send(string message)
            {
                messageService.SendMessage(message);
            }
        }
    }
}
