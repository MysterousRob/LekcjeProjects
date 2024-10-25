// See https://aka.ms/new-console-template for more information
int[,] matrix = new int[3, 4];

int value = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = value;
        value++;
    }
}

// Wyświetlenie macierzy po transpozycji
Console.WriteLine("Macierz po transpozycji:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[j, i] + " ");
    }
    Console.WriteLine();
}