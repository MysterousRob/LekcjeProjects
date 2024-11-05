using System;

class Program
{
    static void Main()
    {
        BuildAndDisplayMatrix(10, 8);
    }

    public static void BuildAndDisplayMatrix(int X, int Y)
    {

        if (X <= 0 || Y <= 0)
        {
            Console.WriteLine("Wymiary macierzy muszą być większe niż zero.");
            return;
        }

        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}
