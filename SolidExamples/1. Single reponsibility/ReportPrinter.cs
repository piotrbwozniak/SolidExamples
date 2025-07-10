namespace SolidExamples._1._Single_reponsibility
{
    class ReportPrinter
    {
        // GOOD: This class has a single responsibility - to print reports.
        public void Print(Report report)
        {
            Console.WriteLine($"Printing report titled '{report.Title}'");
        }
    }
}