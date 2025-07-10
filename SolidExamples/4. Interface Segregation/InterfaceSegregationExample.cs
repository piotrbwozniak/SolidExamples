namespace SolidExamples._4._Interface_Segregation
{
    // I — Interface Segregation Principle
    // Clients should not be forced to depend on interfaces they do not use.
    class InterfaceSegregationExample
    {
        public void Run()
        {
            Console.WriteLine("\n=== Interface Segregation Principle ===");

            // GOOD: OldPrinter depends only on IPrinter interface.
            IPrinter printer = new OldPrinter();
            printer.Print();

            // GOOD: MultiFunctionPrinter implements both interfaces, so clients only use what they need.
            var mfp = new MultiFunctionPrinter();
            mfp.Print();
            mfp.Scan();

            // BAD: If there was a single interface with both Print and Scan, OldPrinter
            // would be forced to implement Scan() it doesn't need, violating ISP.
        }
    }
}