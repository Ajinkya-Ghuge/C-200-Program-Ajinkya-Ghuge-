using System;

namespace Level3_OOPs_Advanced
{
    public class Program119_SolidPrinciplesExamples
    {
        public static void Run()
        {
            Report report = new Report("Monthly Sales");
            ReportPrinter printer = new ReportPrinter();
            printer.Print(report);

            IDiscount discount = new FestivalDiscount();
            Console.WriteLine($"Discounted price: {discount.Apply(1000):C}");
        }

        private class Report
        {
            public Report(string title)
            {
                Title = title;
            }

            public string Title { get; }
        }

        private class ReportPrinter
        {
            public void Print(Report report)
            {
                Console.WriteLine($"Printing report: {report.Title}");
                Console.WriteLine("SRP: report data and printing are separated.");
            }
        }

        private interface IDiscount
        {
            decimal Apply(decimal amount);
        }

        private class FestivalDiscount : IDiscount
        {
            public decimal Apply(decimal amount) => amount * 0.9m;
        }
    }
}
