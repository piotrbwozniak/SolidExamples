namespace SolidExamples._4._Interface_Segregation
{
    class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }
}