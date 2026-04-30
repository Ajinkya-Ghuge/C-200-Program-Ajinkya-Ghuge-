using System;

namespace Level3_OOPs_Advanced
{
    public class Program114_SealedClass
    {
        public static void Run()
        {
            FinalReport report = new FinalReport();
            report.Show();
        }

        private sealed class FinalReport
        {
            public void Show()
            {
                Console.WriteLine("Sealed class cannot be inherited.");
            }
        }
    }
}
