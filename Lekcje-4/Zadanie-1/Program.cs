/* Funkcja zwracająca wartość równania kwadratowego z domyślnymi wartościami parametrów */
double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
{
    return a * x * x + b * x + c;
}

/*Przeciążona wersja funkcji QuadraticEquation przyjmująca tylko jeden parametr x*/
//double QuadraticEquation(double x)
//{
//    return QuadraticEquation(x, 1.0, 1.0, 1.0); // Wywołanie wersji z domyślnymi wartościami a, b, c
//}

Console.WriteLine(QuadraticEquation());             // Wywołanie bez argumentów: wynik to 1.0
Console.WriteLine(QuadraticEquation(2));            // Wynik dla x = 2, a = 1, b = 1, c = 1
Console.WriteLine(QuadraticEquation(2, 2, 3, 4));   // Wynik dla x = 2, a = 2, b = 3, c = 4
