using System;

class Animal
{
    // Właściwości klasy Animal
    public string Name { get; set; }
    public string Species { get; set; }

    // Konstruktor
    public Animal(string name, string species)
    {
        Name = name;
        Species = species;
    }

    // Wyświetlanie informacji o zwierzęciu
    public override string ToString()
    {
        return $"{Name} ({Species})";
    }
}

class Person
{
    public string Name { get; set; }
    public Animal Pet { get; private set; } // Zwierzę jako własność osoby (kompozycja)

    public Person(string name)
    {
        Name = name;
    }

    public void AdoptAPet(Animal pet)
    {
        if (pet == null)
        {
            Console.WriteLine("Nie można adoptować nieistniejącego zwierzęcia.");
            return;
        }

        if (Pet != null)
        {
            Console.WriteLine($"{Name} już ma zwierzę: {Pet.Name}. Nie można adoptować więcej niż jednego zwierzęcia.");
            return;
        }

        Pet = pet;
        Console.WriteLine($"{Name} zaadoptował zwierzę: {pet.Name} ({pet.Species}).");
    }

    public override string ToString()
    {
        return $"{Name}, Zwierzę: {(Pet != null ? Pet.ToString() : "Brak")}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Anna");
        Animal animal = new Animal("Burek", "Pies");

        Console.WriteLine("Przed adopcją:");
        Console.WriteLine(person);

        person.AdoptAPet(animal);

        Console.WriteLine("\nPo adopcji:");
        Console.WriteLine(person);
    }
}
