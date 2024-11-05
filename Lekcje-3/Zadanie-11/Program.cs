using System; 

class Program {
public static string EvenOrOdd(int number)
{
    // Sprawdzenie parzystości liczby
    if (number % 2 == 0)
    {
        return "Even";
    }
    else
    {
        return "Odd";
    }
}
    static void Main(string[] args)
    {
        Console.WriteLine(EvenOrOdd(4));
        Console.WriteLine(EvenOrOdd(7));
    }
}