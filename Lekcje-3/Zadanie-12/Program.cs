// See https://aka.ms/new-console-template for more information
Console.WriteLine(CheckEvenOrOdd(10));
Console.WriteLine(CheckEvenOrOdd(7));

public static string CheckEvenOrOdd(int number)
{
    if (number % 2 == 0)
    {
        return "Even";
    }
    else
    {
        return "Odd";
    }
}