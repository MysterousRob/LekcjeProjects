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

public class Salmon : Animal, ISwimmable
{
    public override string Sound => "Splash";
    public override void Move()
    {
        Console.WriteLine("Swimming fast in water.");
    }

    public void Swim()
    {
        Console.WriteLine("I can swim really fast!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[]
        {
            new Cat(),
            new Dog(),
            new Salmon()
        };

        foreach (var animal in animals)
        {
            if (animal is Mammal mammal)
            {
                mammal.ProduceMilk();
            }

            if (animal is ISwimmable swimmable)
            {
                swimmable.Swim();
            }
        }


    }
}
