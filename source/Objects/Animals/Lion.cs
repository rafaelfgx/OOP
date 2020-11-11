using System;

namespace Objects
{
    public sealed class Lion : Animal
    {
        public Lion() : base(nameof(Lion))
        {
        }

        public override void AfterAwake()
        {
            Eat();
            Drink();
        }

        public override void Move()
        {
            Console.WriteLine("Running");
        }

        public override void Sound()
        {
            Console.WriteLine("Roar");
        }
    }
}
