// See https://aka.ms/new-console-template for more information
int num = 2147483647;         // Maksymalna wartość dla typu int
long bigNum = 88888888888;    // Duża liczba, która nie zmieści się w int
string stringNum = "1024";    // Łańcuch znaków reprezentujący liczbę

// Przypisanie zmiennej typu int do zmiennej typu long
long longNum = num; 
Console.WriteLine($"Wartość longNum: {longNum}");

try
{
    int intNum = (int)bigNum; 
    Console.WriteLine($"Wartość intNum: {intNum}");
}
catch (OverflowException)
{
    Console.WriteLine("OverflowException: Nie można przypisać long do int, wartość jest zbyt duża.");
}

// Przypisanie zmiennej stringNum do zmiennej typu int za pomocą Parse
try
{
    int parsedNum = int.Parse(stringNum);
    Console.WriteLine($"Wartość parsedNum: {parsedNum}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Nie można przekonwertować string na int, niepoprawny format.");
}
   