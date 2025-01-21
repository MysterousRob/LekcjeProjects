using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        ICollection<int> numbers = new List<int> { 1,2,3,4,5 };

        numbers.Add(6);
        numbers.Remove(3);

        Console.WriteLine($"count of numbers: {numbers.Count}");
        Console.WriteLine("Numbers in the collection:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"Contains 4? {numbers.Contains(4)}");

        Console.WriteLine($"Is the collection readonly? {numbers.IsReadOnly}");
    }
}