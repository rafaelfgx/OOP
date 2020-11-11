# Object-Oriented Programming

## Pillars

### Abstraction

Abstraction is to turn real world objects, properties, and behaviors into a computational representation.

### Encapsulation

Encapsulation is to protect internal properties and behaviors of an object from being manipulated externally.

### Inheritance

Inheritance is to reuse properties and behaviors of a base class by a derived class.

### Polymorphism

Polymorphism is the ability of an object to assume and be used as other forms.

## Examples

### Animals

```cs
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
```

```cs
public sealed class Cat : Animal
{
    public Cat() : base(nameof(Cat)) { }

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
```

```cs
public sealed class Dog : Animal
{
    public Dog() : base(nameof(Dog)) { }

    public override void Move()
    {
        Console.WriteLine("Running");
    }

    public override void Sound()
    {
        Console.WriteLine("Bark");
    }
}
```

```cs
public sealed class Duck : Animal
{
    public Duck() : base(nameof(Duck)) { }

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
```

```cs
public sealed class Eagle : Animal
{
    public Eagle() : base(nameof(Eagle)) { }

    public override void Move()
    {
        Console.WriteLine("Flying");
    }

    public override void Sound()
    {
        Console.WriteLine("Screech");
    }
}
```

```cs
public sealed class Lion : Animal
{
    public Lion() : base(nameof(Lion)) { }

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
```

```cs
public sealed class Snake : Animal
{
    public Snake() : base(nameof(Snake)) { }

    public override void Move()
    {
        Console.WriteLine("Crawling");
    }

    public override void Sound()
    {
        Console.WriteLine("Hiss");
    }
}
```

### Notification

```cs
public interface IMessage { }
```

```cs
public sealed class EmailMessage : IMessage
{
    public EmailMessage(string to, string body, string subject)
    {
        To = to;
        Body = body;
        Subject = subject;
    }

    public string Body { get; private set; }

    public string Subject { get; private set; }

    public string To { get; private set; }
}
```

```cs
public sealed class SmsMessage : IMessage
{
    public SmsMessage(string to, string body)
    {
        To = to;
        Body = body;
    }

    public string Body { get; private set; }

    public string To { get; private set; }
}
```

```cs
public interface INotification<TMessage> where TMessage : IMessage
{
    void Notify(TMessage message);
}
```

```cs
public sealed class EmailNotification : INotification<EmailMessage>
{
    public void Notify(EmailMessage message)
    {
        Console.WriteLine(nameof(EmailNotification));
    }
}
```

```cs
public sealed class SmsNotification : INotification<SmsMessage>
{
    public void Notify(SmsMessage message)
    {
        Console.WriteLine(nameof(SmsNotification));
    }
}
```

### Payment

```cs
public interface IPayment
{
    void Pay(decimal value);
}
```

```cs
public sealed class Cash : IPayment
{
    public void Pay(decimal value)
    {
        Console.WriteLine(nameof(Cash));
    }
}
```

```cs
public sealed class CreditCard : IPayment
{
    public void Pay(decimal value)
    {
        Console.WriteLine(nameof(CreditCard));
    }
}
```

```cs
public sealed class DebitCard : IPayment
{
    public void Pay(decimal value)
    {
        Console.WriteLine(nameof(DebitCard));
    }
}
```

```cs
public sealed class PaymentService
{
    public PaymentService(IPayment payment)
    {
        Payment = payment;
    }

    private IPayment Payment { get; }

    public void Pay(decimal value)
    {
        Payment.Pay(value);
    }
}
```

### Repositories

```cs
public interface IRepository<T>
{
    void Insert(T entity);

    IEnumerable<T> List();

    T Select(int id);

    void Update(T entity);
}
```

```cs
public abstract class MySqlRepository<T> : IRepository<T>
{
    public void Insert(T entity)
    {
        /// Implementation
    }

    public IEnumerable<T> List()
    {
        /// Implementation

        return new List<T>();
    }

    public T Select(int id)
    {
        /// Implementation

        return default;
    }

    public void Update(T entity)
    {
        /// Implementation
    }
}
```

```cs
public abstract class SqlServerRepository<T> : IRepository<T>
{
    public void Insert(T entity)
    {
        /// Implementation
    }

    public IEnumerable<T> List()
    {
        /// Implementation

        return new List<T>();
    }

    public T Select(int id)
    {
        /// Implementation

        return default;
    }

    public void Update(T entity)
    {
        /// Implementation
    }
}
```

```cs
public sealed class Entity
{
    public int Id { get; set; }

    public string Name { get; set; }
}
```

```cs
public interface IEntityRepository : IRepository<Entity> { }
```

```cs
public sealed class EntityMySqlRepository : MySqlRepository<Entity>, IEntityRepository { }
```

```cs
public sealed class EntitySqlServerRepository : SqlServerRepository<Entity>, IEntityRepository { }
```
