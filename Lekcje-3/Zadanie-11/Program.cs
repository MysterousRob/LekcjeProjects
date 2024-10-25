// See https://aka.ms/new-console-template for more information

{
    BuildAndPrintMatrix(3, 5);
}

public static void BuildAndPrintMatrix(int x, int y)
{
    for int(int i = 0; i < 3; ++i)
    {
        for int(int j = 0; j < y; j++)
        {
            Console.Write("$");
        }
        Console.WriteLine();
    }
}