// See https://aka.ms/new-console-template for more information
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// Sprawdzenie, czy z odcinków można zbudować trójkąt (Nierówność trójkąta)
bool canFormTriangle = (lengthA + lengthB > lengthC) && (lengthA + lengthC > lengthB) && (lengthB + lengthC > lengthA);

// Zmienna do sprawdzenia, czy trójkąt jest prostokątny
bool isRightTriangle = false;

if (canFormTriangle)
{
    // Sprawdzenie, czy jest to trójkąt prostokątny (Twierdzenie Pitagorasa)
    double aSquared = Math.Pow(lengthA, 2);
    double bSquared = Math.Pow(lengthB, 2);
    double cSquared = Math.Pow(lengthC, 2);

    isRightTriangle = (aSquared + bSquared == cSquared) || (aSquared + cSquared == bSquared) || (bSquared + cSquared == aSquared);
}

// Wypisanie wyników
Console.WriteLine("Czy można zbudować trójkąt: " + canFormTriangle);
if (canFormTriangle)
{
    Console.WriteLine("Czy trójkąt jest prostokątny: " + isRightTriangle);
}

/*Przykład*/
//static void Main(string[] args)
//{
//    int a = 5;        
//    {
//        int b = 3;    
//        ...
//        b = a * 3;    
//    }
//    b = a * 3;        
//}