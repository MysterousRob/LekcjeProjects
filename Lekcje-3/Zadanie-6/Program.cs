// See https://aka.ms/new-console-template for more information
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

Console.WriteLine("Liczby, które nie są podzielne przez 7:");

foreach (int number in numbers)
{
    if (number % 7 == 0)
    {
        continue;
    }
    Console.WriteLine(number);