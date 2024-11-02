
//moźna zkomentować kazdych rzeby zobaczyc czy to robi???

/*a) Funkcja Multiply z 2 parametrami typu double*/
double Multiplya(double a, double b)
{
    return a * b;
}
Console.WriteLine(Multiplya(2.0, 3.0));
/*b) Funkcja Multiply dla trzech parametrów typu double*/
double Multiplyb(double a, double b, double c)
{
    return a * b * c;
}
Console.WriteLine(Multiplyb(2.0, 3.0, 4.0));
/*c) Funkcja Multiply dla tablicy parametrów typu double*/
double Multiplyc(params double[] numbers)
{
    double result = 1;
    foreach (double num in numbers)
    {
        result *= num;
    }
    return result;
}
Console.WriteLine(Multiplyc(2.0, 3.0, 3.0, 4.0, 5.0));


// notes
/*
 // Definicja typu wyliczeniowego Season
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

// Definicja typu wyliczeniowego ErrorCode z przypisanymi wartościami
enum ErrorCode : ushort
{
    None = 0,
    Unknown = 1,
    ConnectionLost = 100,
    OutlierReading = 200
}

 ErrorCode code = ErrorCode.ConnectionLost;
int numericCode = (int)code;  // numericCode wynosi 100

 Season currentSeason = Season.Summer;
Console.WriteLine(currentSeason);            // Wyjście: Summer
Console.WriteLine((int)currentSeason);       // Wyjście: 1 (wartość liczby odpowiadająca Summer)


 */