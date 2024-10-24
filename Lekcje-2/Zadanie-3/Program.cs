// See https://aka.ms/new-console-template for more information
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;


// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b  
int c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b  
int d = a - b;
// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b  
int e = a * b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b  
int f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b  
int g = a % b;
// wypisz na ekran c,d,e,f,g 

Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);

decimal priceSquare = price * price;
Console.WriteLine($"Price * Price: {priceSquare}");

// doubleVal pomnożone przez samo siebie
double doubleValSquare = doubleVal * doubleVal;
Console.WriteLine($"doubleVal * doubleVal: {doubleValSquare}");

// Różnica wynika z precyzji typów - decimal ma większą precyzję dla liczb dziesiętnych niż double.

// Pole koła o promieniu równym radius
double circleArea = Math.PI * Math.Pow(radius, 2);
Console.WriteLine($"Pole koła o promieniu {radius}: {circleArea}");

// Oblicz godziny, minuty i sekundy na podstawie zmiennej time (czas w minutach)
int hours = (int)time / 60; 
int minutes = (int)time % 60; 
int seconds = (int)((time - (int)time) * 60); 

Console.WriteLine($"Czas: {hours} godzin, {minutes} minut, {seconds} sekund");