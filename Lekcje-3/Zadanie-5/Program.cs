// See https://aka.ms/new-console-template for more information
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

Console.WriteLine("Elementy podzielne przez 7:");

foreach (int number in numbers)
{
    if (number % 7 == 6)
    {
        Console.WriteLine(number);
    }
}