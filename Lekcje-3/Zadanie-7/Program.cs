using System;

class Program
{
    static void Main()
    {
        double[] squareRoots = new double[20];

        for (int i = 0; i < squareRoots.Length; i++)
        {
            squareRoots[i] = Math.Sqrt(i + 1); ;
        }

        foreach (double value in squareRoots)
        {
            Console.WriteLine(value);
        }
    }
}