public class Human
{
    public string Name { get; set; }
    public Human Mother { get; set; }
    public Human Father { get; set; }


}

public class Adult : Human
{
    // the adult would inherit from the human class
}

public class Child : Human
{
    // the child would inherit from the Human
}

class Program
{
    static void Main(string[] args)
    {
        Adult john = new Adult { Name = "John" };
        Adult jane = new Adult { Name = "Jane" };

        Child kevin = new Child { Name = "Kevin", Mother = jane, Father = john };
        Child mike = new Child { Name = "Mike", Mother = jane, Father = john };
        Child wendy = new Child { Name = "Wendy", Mother = jane, Father = john };

        Console.WriteLine($"Adults: {john.Name} and {jane.Name} have 3 children: {kevin.Name}, {mike.Name}, {wendy.Name}");
    }
}
