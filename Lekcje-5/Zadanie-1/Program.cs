using System;

public struct Coords
{
    public double X { get; }
    public double Y { get; }

    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }
}

public class Program
{
    public static double CalculatePolylineLength(Coords[] points)
    {
        double length = 0.0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            double dx = points[i + 1].X - points[i].X;
            double dy = points[i + 1].Y - points[i].Y;
            length += Math.Sqrt(dx * dx + dy * dy);
        }

        return length;
    }

    public static Coords[] ReadPoints(int numberOfPoints)
    {
        Coords[] points = new Coords[numberOfPoints];

        for (int i = 0; i < numberOfPoints; i++)
        {
            Console.Write($"Podaj współrzędne punktu {i + 1} (x y): ");
            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            points[i] = new Coords(x, y);
        }

        return points;
    }

    public static void Main(string[] args)
    {
        Console.Write("Podaj liczbę punktów linii łamanej: ");
        int numberOfPoints = int.Parse(Console.ReadLine());

        Coords[] points = ReadPoints(numberOfPoints);

        double length = CalculatePolylineLength(points);

        Console.WriteLine($"Długość linii łamanej wynosi: {length}");
    }
}
