using System;

namespace Objects
{
    public sealed class Snake : Animal
    {
        public Snake() : base(nameof(Snake))
        {
        }

        public override void Move()
        {
            Console.WriteLine("Crawling");
        }

        public override void Sound()
        {
            Console.WriteLine("Hiss");
        }
    }
}
