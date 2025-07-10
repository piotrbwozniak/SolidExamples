namespace SolidExamples._3._Liskov_Substitution
{
    // L — Liskov Substitution Principle
    // Objects of a superclass should be replaceable with objects of a subclass without affecting correctness.
    class LiskovSubstitutionExample
    {
        public void Run()
        {
            Console.WriteLine("\n=== Liskov Substitution Principle ===");
            Bird sparrow = new Sparrow();
            sparrow.Fly(); // Works correctly

            Bird ostrich = new Ostrich();
            try
            {
                ostrich.Fly(); // Throws exception - violates LSP
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}