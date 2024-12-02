using System;

class Program
{
    static void Main()
    {
        double numerator = 9;
        double denominator = 0;

        double result = Divide(numerator, denominator);
        Console.WriteLine($"Rezultat dzielenia: {result}");
    }
    static double Divide( double dividend, double divisor )
    {
        try
        {
            return dividend / divisor;
        } 
        catch (DivideByZeroException)
        {
            Console.WriteLine("Błąd: próba dzielenia przez zero.");
            return 0;
        }
    }
}