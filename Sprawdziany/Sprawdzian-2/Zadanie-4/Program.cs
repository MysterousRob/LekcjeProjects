public class Human
{
    public string Name { get; set; }

    public Human(string name)
    {
        Name = name;
    }
    
    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}");
    }
}

public interface ISinger
{
    string Sing();
}

public class Adult : Human
{
    public Adult(string name) : base(name) { }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

public class Child : Human, ISinger
{
    public Child(string name) : base(name) { }
    public string Sing()
    {
        return "Baby shark doo doo doo doo doo";
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is playing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Human[] humans = { new Adult("John"), new Child("Kevin") };

        foreach (var h in humans)
        {
            if (h is ISinger singer)
            {
                Console.WriteLine(singer.Sing()); 
            }
            else
            {
                Console.WriteLine($"{h.Name} cannot sing.");
            }
        }
    }
}
