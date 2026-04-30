using System;

namespace Level3_OOPs_Advanced
{
    public class Program134_Delegates
    {
        private delegate void MessageDelegate(string message);

        public static void Run()
        {
            MessageDelegate messenger = ShowMessage;
            messenger("Delegate invoked successfully.");
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
