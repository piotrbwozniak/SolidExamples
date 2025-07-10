namespace SolidExamples._1._Single_reponsibility
{
    class Report
    {
        public string Title { get; }
        public string Content { get; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        // BAD: This method mixes responsibilities - Report class should only hold data,
        // not handle how it is printed or displayed.
        public void PrintReport()
        {
            Console.WriteLine($"Report: {Title}\n{Content}");
        }
    }
}