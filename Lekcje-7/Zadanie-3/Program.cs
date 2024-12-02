using System;

public abstract class Animal
{
    public abstract string Sound { get; }
    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }
}

public abstract class Mammal : Animal
{
    public abstract void ProduceMilk();
}

public interface IWalkable
{
    void Walk();
}

public class Dog : Mammal, IWalkable
{
    public override string Sound => "Woof";
    public override void Move()
    {
        Console.WriteLine("Running like a dog...");
    }

    public override void ProduceMilk()
    {
        Console.WriteLine("Producing milk for puppies.");
    }

    public void Walk()
    {
        Console.WriteLine("I walk on a leash.");
    }
}

public class Cat : Mammal, IWalkable
{
    public override string Sound => "Meow";
    public override void Move()
    {
        Console.WriteLine("Walking like a cat...");
    }

    public override void ProduceMilk()
    {
        Console.WriteLine("Producing milk for kittens.");
    }

    public void Walk()
    {
        Console.WriteLine("I like walking on furniture and tables.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Walk();

        Cat cat = new Cat();
        cat.Walk();

        IWalkable walkableCat = new Cat();
        walkableCat.Walk();
    }
}
