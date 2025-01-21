using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        ICollection<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };

        Console.WriteLine("Original Collection:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Add("Elderberry");
        Console.WriteLine("\nAfter adding 'Elderberry':");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Remove("Banana");
        Console.WriteLine("\nAfter removing 'Banana':");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nDoes the collection contain 'Cherry'? " + fruits.Contains("Cherry"));
        Console.WriteLine("Does the collection contain 'Banana'? " + fruits.Contains("Banana"));


        Console.WriteLine("\nNumber of elements in the collection: " + fruits.Count);
        
        fruits.Clear();
        Console.WriteLine("\nAfter clearing the collection:");
        Console.WriteLine("Number of elements: " + fruits.Count);
    }
}