using System;

namespace Objects
{
    public sealed class Duck : Animal
    {
        public Duck() : base(nameof(Duck))
        {
        }

        public override void AfterAwake()
        {
            Move();
        }

        public override void Move()
        {
            Console.WriteLine("Swimming");
        }

        public override void Sound()
        {
            Console.WriteLine("Quack");
        }
    }
}
