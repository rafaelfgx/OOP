namespace Objects
{
    public sealed class SmsMessage : IMessage
    {
        public SmsMessage(string to, string body)
        {
            To = to;
            Body = body;
        }

        public string Body { get; private set; }

        public string To { get; private set; }
    }
}
