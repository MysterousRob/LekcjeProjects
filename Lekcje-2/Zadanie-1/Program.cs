// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zmienne i typy danych");

byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";

// tutaj wpisz rozwiązanie 

Console.WriteLine(byteVariable);
Console.WriteLine(integralVariable);
Console.WriteLine(longVariable);
Console.WriteLine(charVariable1);
Console.WriteLine(charVariable2);
Console.WriteLine(doubleVariable);
Console.WriteLine(floatVariable);
Console.WriteLine(stringVariable);
// konwersja niejawna 

int num = 100;
long bigNum = num;

Console.WriteLine(bigNum);

// konwersja jawna 

double x = 1234.7;
int a;
a = (int)x;

Console.WriteLine(a);

