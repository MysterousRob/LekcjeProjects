using System;

class Program
{
    public static (int Min, int Max) FindMinMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int min = numbers[0];
        int max = numbers[0];

        foreach (var num in numbers)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return (min, max);
    }

    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 1, 9, 4, -2, 10 };

        var (min, max) = FindMinMax(numbers);

        Console.WriteLine($"Najmniejsza liczba: {min}");
        Console.WriteLine($"Największa liczba: {max}");
    }
}

