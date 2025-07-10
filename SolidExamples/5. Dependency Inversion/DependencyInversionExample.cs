namespace SolidExamples._5._Dependency_Inversion
{
    // D — Dependency Inversion Principle
    // High-level modules should not depend on low-level modules; both should depend on abstractions.
    // Abstractions should not depend on details; details should depend on abstractions.
    class DependencyInversionExample
    {
        public void Run()
        {
            Console.WriteLine("\n=== Dependency Inversion Principle ===");

            var emailNotification = new Notification(new EmailSender());
            emailNotification.Notify("Hello via Email!");

            var smsNotification = new Notification(new SmsSender());
            smsNotification.Notify("Hello via SMS!");

            // BAD: If Notification created EmailSender or SmsSender directly, it would depend on concrete classes,
            // making it hard to extend or test.
        }
    }
}