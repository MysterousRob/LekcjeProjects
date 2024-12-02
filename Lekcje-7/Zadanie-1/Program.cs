using System;

public abstract class Animal
{
    public abstract string Sound { get; }

    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }
}

public class Cat : Animal
{
    public override string Sound => "Meow";

    public override void Move()
    {
        Console.WriteLine("Walking like a cat...");
    }

    public void ThrowOfTheTable()
    {
        Console.WriteLine("Cat threw something off the table!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat myCat = new Cat();

        Console.WriteLine($"Dźwięk kota: {myCat.Sound}");
        myCat.Move();
        myCat.ThrowOfTheTable();
    }
}
