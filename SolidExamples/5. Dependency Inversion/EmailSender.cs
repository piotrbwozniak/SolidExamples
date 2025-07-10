namespace SolidExamples._5._Dependency_Inversion
{
    class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
}