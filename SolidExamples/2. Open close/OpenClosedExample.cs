namespace SolidExamples._2._Open_close
{
    // O — Open/Closed Principle
    // Software entities should be open for extension, but closed for modification.
    class OpenClosedExample
    {
        public void Run()
        {
            Console.WriteLine("\n=== Open/Closed Principle ===");
            decimal price = 100m;

            // GOOD: We can extend discount behavior by creating new subclasses without modifying existing ones.
            Discount discount = new NoDiscount();
            Console.WriteLine($"Price without discount: {discount.Apply(price)}");

            discount = new SeasonalDiscount(0.1m);
            Console.WriteLine($"Price with seasonal discount: {discount.Apply(price)}");

            // BAD: If we modify existing classes to add new discounts instead of extending,
            // it breaks the Open/Closed Principle.
        }
    }
}