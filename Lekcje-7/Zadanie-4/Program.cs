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

public interface ISwimmable
{
    void Swim();
}

public class Dog : Mammal, IWalkable, ISwimmable
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

    public void Swim()
    {
        Console.WriteLine("I swim poorly...");
    }
}

public class Salmon : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("I can swim really fast!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Swim();

        Salmon salmon = new Salmon();
        salmon.Swim();

        if (dog is ISwimmable)
        {
            Console.WriteLine("Dog is swimmable.");
        }

        if (salmon is ISwimmable)
        {
            Console.WriteLine("Salmon is swimmable.");
        }

        ISwimmable swimmableDog = dog as ISwimmable;
        swimmableDog?.Swim();

        ISwimmable swimmableSalmon = salmon as ISwimmable;
        swimmableSalmon?.Swim();
    }
}
