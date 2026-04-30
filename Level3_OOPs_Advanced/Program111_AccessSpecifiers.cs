using System;

namespace Level3_OOPs_Advanced
{
    public class Program111_AccessSpecifiers
    {
        public static void Run()
        {
            AccessDemo demo = new AccessDemo();
            Console.WriteLine(demo.PublicMessage);
            Console.WriteLine(demo.GetPrivateMessage());
            Console.WriteLine(demo.ProtectedInternalMessage);
        }

        private class AccessDemo
        {
            public string PublicMessage = "Public members are accessible everywhere.";
            private string PrivateMessage = "Private members are accessible only inside the class.";
            protected internal string ProtectedInternalMessage = "Protected internal members are accessible in derived classes or same assembly.";

            public string GetPrivateMessage() => PrivateMessage;
        }
    }
}
