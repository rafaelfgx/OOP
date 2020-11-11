using System;

namespace Objects
{
    public sealed class SmsNotification : INotification<SmsMessage>
    {
        public void Notify(SmsMessage message)
        {
            Console.WriteLine(nameof(SmsNotification));
        }
    }
}
