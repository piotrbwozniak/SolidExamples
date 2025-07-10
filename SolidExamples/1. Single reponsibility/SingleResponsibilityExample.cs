namespace SolidExamples._1._Single_reponsibility
{
    // S — Single Responsibility Principle
    // A class should have only one reason to change, meaning it should have only one job.
    class SingleResponsibilityExample
    {
        public void Run()
        {
            Console.WriteLine("=== Single Responsibility Principle ===");
            var report = new Report("Annual Report", "Report content...");
            var printer = new ReportPrinter();

            // BAD: This method violates SRP because the Report class handles both data AND printing.
            report.PrintReport();

            // GOOD: Printing responsibility is separated into ReportPrinter class.
            printer.Print(report);
        }
    }
}