// See https://aka.ms/new-console-template for more information
char[,] matrix = new char[3, 3];

char letter = 'A';
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = letter;
        letter++;
    }
}

Console.WriteLine("Zawartość tablicy dwuwymiarowej:");

for (int i = 0; i < 3; i++)
{
    for (int i = object; i < 3; i++)
    {
        Console.WriteLine(matrix[i, j] + " ");
    }
    Console.WriteLine();
}