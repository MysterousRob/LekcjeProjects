

int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement++;

// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;

// Sprawdzenie wyników
Console.WriteLine("toIncrement: " + toIncrement);
Console.WriteLine("toDivide: " + toDivide);

//Math.Sqrt(9);            // pierwiastek kwadratowy
//Math.Pow(3, 2);           // potęgowanie
//Math.Abs(-10);           // moduł
//Math.Sin(1.57);          // sinus kąta w radianach
//Math.Round(1.5);         // zaokrąglenie do najbliższej wartości całkowitej
//Math.Round(2.5);         // wynik taki jak dla funkcji wyżej   
//Math.Truncate(1.95);     // część całkowita liczby zmiennoprzecinkowej
//Math.Ceiling(1.95);      // najmniejsza liczba całkowita większa lub równa argumentowi
//Math.Floor(1.95);        // największa liczba całkowita mniejsza lub równa argumentowi 
//Math.Clamp(4, 0, 10));   // ograniczenie pierwszego argumentu do zakresu
//Math.Max(2, 6);          // zwraca większy argument
//Math.Min(2, 6);          // zwraca mniejszy argument
//Math.Sign(-2);           // zwraca liczbę określającą znak argumentu: - 1, 0 lub 1

//Math.PI
//Math.E
//Math.Tau

//nie jest potrxebna źeby to napisać 
double sqrt = Math.Sqrt(9);  // Wynik: 3
double pow = Math.Pow(3, 2);  // Wynik: 9
int abs = Math.Abs(-10);  // Wynik: 10
double sin = Math.Sin(1.57);  // Wynik: około 1 (sin(π/2) ≈ 1)
double round1 = Math.Round(1.5);  // Wynik: 2
double round2 = Math.Round(2.5);  // Wynik: 2
double truncate = Math.Truncate(1.95);  // Wynik: 1
double ceiling = Math.Ceiling(1.95);  // Wynik: 2
double floor = Math.Floor(1.95);  // Wynik: 1
int clampedValue = Math.Clamp(4, 0, 10);  // Wynik: 4 (w zakresie 0-10)
int max = Math.Max(2, 6);  // Wynik: 6
int min = Math.Min(2, 6);  // Wynik: 2
int sign = Math.Sign(-2);  // Wynik: -1

//(tylko na testowanie)
Console.WriteLine(sqrt);
Console.WriteLine(pow);
Console.WriteLine(abs);
Console.WriteLine(sin);
Console.WriteLine(round1);
Console.WriteLine(round2);
Console.WriteLine(truncate);
Console.WriteLine(ceiling);
Console.WriteLine(floor);
Console.WriteLine(clampedValue);
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(sign);

//double pi = Math.PI;  
//double e = Math.E; 
//double tau = Math.Tau; 