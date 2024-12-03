using System;

public interface IWalkable
{
    void Walk();
}

public interface ISwimmable
{
    void Swim();
}

public abstract class Animal
{
    public abstract string Sound { get; }
    public abstract void Move();
}

public abstract class Mammal : Animal
{
    public abstract void ProduceMilk();
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

    public override string ToString()
    {
        return "I'm a Cat, I do Meow";
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

    public override string ToString()
    {
        return "I'm a Dog, I do Woof";
    }
}

public class Salmon : Animal, ISwimmable
{
    public override string Sound => "Glub";

    public override void Move()
    {
        Console.WriteLine("Swimming like a salmon...");
    }

    public void Swim()
    {
        Console.WriteLine("I can swim really fast!");
    }

    public override string ToString()
    {
        return "I'm a Salmon, I do Glub";
    }
}

class Program
{
    static void Main()
    {
        // Tworzymy tablicę zwierząt
        Animal[] animals = new Animal[]
        {
            new Cat(),
            new Dog(),
            new Salmon()
        };

        // Iteracja przez tablicę
        foreach (var animal in animals)
        {
            // Sprawdzanie, czy obiekt jest ssakiem
            if (animal is Mammal mammal)
            {
                mammal.ProduceMilk();
            }

            // Sprawdzanie, czy obiekt implementuje ISwimmable
            if (animal is ISwimmable swimmable)
            {
                swimmable.Swim();
            }

            // Wywołanie ToString
            Console.WriteLine(animal.ToString());
        }
    }
}

