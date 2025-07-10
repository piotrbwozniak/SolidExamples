namespace SolidExamples._5._Dependency_Inversion
{
    class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}