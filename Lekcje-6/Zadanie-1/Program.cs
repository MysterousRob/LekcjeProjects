using System;

class Person
{
    public string Name { get; set; }
    public Person Partner { get; set; } 

    public Person(string name)
    {
        Name = name;
    }

    public static void Relate(Person p1, Person p2)
    {
        if (p1 == null || p2 == null)
        {
            Console.WriteLine("Obie osoby muszą być zdefiniowane.");
            return;
        }

        p1.Partner = p2;
        p2.Partner = p1;

        Console.WriteLine($"{p1.Name} i {p2.Name} zostali powiązani jako partnerzy.");
    }

    public override string ToString()
    {
        return $"{Name}, Partner: {(Partner != null ? Partner.Name : "Brak")}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Anna");
        Person person2 = new Person("Jan");

        Console.WriteLine("Przed nawiązaniem relacji:");
        Console.WriteLine(person1);
        Console.WriteLine(person2);

        // Nawiązanie relacji
        Person.Relate(person1, person2);

        Console.WriteLine("\nPo nawiązaniu relacji:");
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }
}

