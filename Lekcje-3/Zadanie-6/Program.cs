using System;

class Program
{
    static void Main()
    {
        int number = 30; 
        int[] divisors = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }; 

        foreach (int divisor in divisors)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine($"Pierwszy dzielnik liczby {number} to: {divisor}");
                break; 
            }
        }
    }
}
