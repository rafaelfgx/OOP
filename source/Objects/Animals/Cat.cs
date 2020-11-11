using System;

namespace Objects
{
    public sealed class Cat : Animal
    {
        public Cat() : base(nameof(Cat))
        {
        }

        public override void AfterAwake()
        {
            Drink();
        }

        public override void Move()
        {
            Console.WriteLine("Climbing");
        }

        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
}
