using System;

namespace Objects
{
    public sealed class DebitCard : IPayment
    {
        public void Pay(decimal value)
        {
            Console.WriteLine(nameof(DebitCard));
        }
    }
}
