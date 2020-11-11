using System;

namespace Objects
{
    public sealed class Cash : IPayment
    {
        public void Pay(decimal value)
        {
            Console.WriteLine(nameof(Cash));
        }
    }
}
