using Objects;
using System;
using System.Collections.Generic;

namespace App
{
    public static class Program
    {
        private static IEnumerable<Animal> Animals => new List<Animal>
        {
            new Cat(),
            new Dog(),
            new Duck(),
            new Eagle(),
            new Lion(),
            new Snake()
        };

        public static void Main()
        {
            Abstraction();
            Encapsulation();
            Polymorphism();
            DependencyInjection();

            Console.ReadKey();
        }

        private static void Abstraction()
        {
            ShowTitle(nameof(Abstraction));

            IEntityRepository repository;

            repository = new EntitySqlServerRepository();

            Console.WriteLine(repository.GetType().Name);

            repository = new EntityMySqlRepository();

            Console.WriteLine(repository.GetType().Name);

            Console.WriteLine();
        }

        private static void DependencyInjection()
        {
            ShowTitle(nameof(DependencyInjection));

            new PaymentService(new Cash()).Pay(1000);
            new EmailNotification().Notify(new EmailMessage("To", "Subject", "Body"));
            new SmsNotification().Notify(new SmsMessage("Number", "Body"));

            new PaymentService(new CreditCard()).Pay(1000);
            new SmsNotification().Notify(new SmsMessage("Number", "Body"));

            new PaymentService(new CreditCard()).Pay(2000);
            new EmailNotification().Notify(new EmailMessage("To", "Subject", "Body"));

            new PaymentService(new DebitCard()).Pay(1000);
            new SmsNotification().Notify(new SmsMessage("Number", "Body"));

            Console.WriteLine();
        }

        private static void Encapsulation()
        {
            ShowTitle(nameof(Encapsulation));

            foreach (var animal in Animals)
            {
                ShowAnimalSleeping(animal);

                animal.Sleep();

                ShowAnimalSleeping(animal);

                animal.Awake();

                ShowAnimalSleeping(animal);

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void Polymorphism()
        {
            ShowTitle(nameof(Polymorphism));

            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Name);

                animal.Move();

                animal.Sound();

                Console.WriteLine();
            }
        }

        private static void ShowAnimalSleeping(Animal animal)
        {
            Console.WriteLine("{0} sleeping? {1}", animal.Name, animal.Sleeping ? "Yes" : "No");
        }

        private static void ShowTitle(string title)
        {
            Console.WriteLine(title.ToUpper());
            Console.WriteLine();
        }
    }
}
