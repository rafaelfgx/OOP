using System;

namespace Objects
{
    public sealed class Dog : Animal
    {
        public Dog() : base(nameof(Dog))
        {
        }

        public override void Move()
        {
            Console.WriteLine("Running");
        }

        public override void Sound()
        {
            Console.WriteLine("Bark");
        }
    }
}
