using System;

namespace Objects
{
    public abstract class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public bool Sleeping { get; private set; }

        public virtual void AfterAwake() { }

        public void Awake()
        {
            Sleeping = false;

            Console.WriteLine(nameof(Awake));

            AfterAwake();
        }

        public void Drink()
        {
            Console.WriteLine(nameof(Drink));
        }

        public void Eat()
        {
            Console.WriteLine(nameof(Eat));
        }

        public abstract void Move();

        public void Sleep()
        {
            Sleeping = true;

            Console.WriteLine(nameof(Sleep));
        }

        public abstract void Sound();
    }
}
