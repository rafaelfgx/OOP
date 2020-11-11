using System;

namespace Objects
{
    public sealed class EmailNotification : INotification<EmailMessage>
    {
        public void Notify(EmailMessage message)
        {
            Console.WriteLine(nameof(EmailNotification));
        }
    }
}
