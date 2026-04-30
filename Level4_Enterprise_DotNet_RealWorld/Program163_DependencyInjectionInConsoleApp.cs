using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program163_DependencyInjectionInConsoleApp
    {
        public static void Run()
        {
            IReportService reportService = new ReportService();
            App app = new App(reportService);
            app.Start();
        }

        private interface IReportService
        {
            string Generate();
        }

        private class ReportService : IReportService
        {
            public string Generate() => "Monthly report generated.";
        }

        private class App
        {
            private readonly IReportService reportService;

            public App(IReportService reportService)
            {
                this.reportService = reportService;
            }

            public void Start()
            {
                Console.WriteLine(reportService.Generate());
            }
        }
    }
}
