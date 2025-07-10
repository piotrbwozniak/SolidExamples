namespace SolidExamples._5._Dependency_Inversion
{
    class Notification
    {
        private readonly IMessageSender _messageSender;

        // GOOD: Notification depends on abstraction IMessageSender, not concrete implementations.
        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Notify(string message)
        {
            _messageSender.Send(message);
        }
    }
}