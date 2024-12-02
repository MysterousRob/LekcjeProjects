// Klasa Cat
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

    // Nadpisanie metody ToString
    public override string ToString()
    {
        return "I'm a Cat, I do Meow";
    }
}

// Klasa Dog
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

    // Nadpisanie metody ToString
    public override string ToString()
    {
        return "I'm a Dog, I do Woof";
    }
}

// Klasa Salmon
public class Salmon : IWalkable, ISwimmable
{
    public void Walk()
    {
        Console.WriteLine("I swim upstream.");
    }

    public void Swim()
    {
        Console.WriteLine("I can swim really fast!");
    }

    // Nadpisanie metody ToString
    public override string ToString()
    {
        return "I'm a Salmon, I do Glub";
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        Salmon salmon = new Salmon();

        // Wywołanie ToString na obiektach
        Console.WriteLine(dog.ToString());    // Output: I'm a Dog, I do Woof
        Console.WriteLine(cat.ToString());    // Output: I'm a Cat, I do Meow
        Console.WriteLine(salmon.ToString()); // Output: I'm a Salmon, I do Glub
    }
}

