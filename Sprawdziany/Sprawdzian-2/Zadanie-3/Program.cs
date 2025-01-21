public class Human
{
    public string Name { get; set; }


    public virtual string EatSnack()
    {
        return "IceCream!";
    }
}

public class Adult : Human
{
    public override string EatSnack()
    {
        return "Cake.";
    }
}

public class Child : Human
{
    //the child would inherit EatSnack without an override
}

class Program
{
    static void Main(string[] args)
    {
        Human humanAdult = new Adult();
        Console.WriteLine(humanAdult.EatSnack());

        Human childAdult = new Child();
        Console.WriteLine(childAdult.EatSnack());
    }
}