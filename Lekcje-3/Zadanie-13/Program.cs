using System;

class Program
{
    // Function to calculate the roots of the quadratic equation
    public static double[] ObliczRozwiazania(double a, double b, double c)
    {
        // Check if a is zero to avoid division by zero
        if (a == 0)
        {
            throw new ArgumentException("Współczynnik 'a' nie może być równy zero.");
        }

        double D = b * b - 4 * a * c; // Calculate the discriminant

        if (D > 0)
        {
            // Two distinct real roots
            double root1 = (-b + Math.Sqrt(D)) / (2 * a);
            double root2 = (-b - Math.Sqrt(D)) / (2 * a);
            return new double[] { root1, root2 }; // Return the roots as an array
        }
        else if (D == 0)
        {
            // One double root
            double root = -b / (2 * a);
            return new double[] { root }; // Return the single root as an array
        }
        else
        {
            // No real roots
            return new double[0]; // Return an empty array
        }
    }

    static void Main(string[] args)
    {
        // Example usage
        Console.Write("Podaj współczynnik a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Podaj współczynnik b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Podaj współczynnik c: ");
        double c = double.Parse(Console.ReadLine());

        try
        {
            double[] roots = ObliczRozwiazania(a, b, c);

            if (roots.Length == 0)
            {
                Console.WriteLine("Równanie nie ma rozwiązań rzeczywistych.");
            }
            else
            {
                Console.WriteLine("Rozwiązania równania kwadratowego:");
                foreach (var root in roots)
                {
                    Console.WriteLine(root);
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
