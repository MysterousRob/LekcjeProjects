// See https://aka.ms/new-console-template for more information
public static double[] rozwiązanieKwadratowe(double a, double b, double c)
{
    if (a == 0)
    {
        throw new ArgumentException(("Współczynnik 'a' nie może być zerem w równaniu kwadratowym.");
    }

    double delta = b * b - 4 * a * c;

    if (delta > 0)
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        return new double[] { x1, x2 };
    }
    else if (delta == 0)
    {
        double x = -b / (2 * a);
        return new double[] { x };
    }
    else
    {
        return new double[] { };
    }
    
    public static void Main()
    {
        double a = 1, b = -3, c = 2;
        double[] wynik = rozwiązanieKwadratowe(a, b, c);

        Console.WriteLine("Rozwiązania równania kwadratowego:");
        foreach (var x in wynik)
        {
            Console.WriteLine(x);
        }
}