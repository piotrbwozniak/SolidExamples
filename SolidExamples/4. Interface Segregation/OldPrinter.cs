namespace SolidExamples._4._Interface_Segregation
{
    class OldPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }
}