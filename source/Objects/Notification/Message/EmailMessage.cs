namespace Objects
{
    public sealed class EmailMessage : IMessage
    {
        public EmailMessage(string to, string body, string subject)
        {
            To = to;
            Body = body;
            Subject = subject;
        }

        public string Body { get; private set; }

        public string Subject { get; private set; }

        public string To { get; private set; }
    }
}
