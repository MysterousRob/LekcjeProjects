// See https://aka.ms/new-console-template for more information
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// Stworzenie zmiennej typu DateTime
DateTime date = new DateTime(year, month, day, hour, minute, 0);

// Dodanie 3 miesięcy i odjęcie 1 godziny
date = date.AddMonths(3).AddHours(-1);

// Wypisanie na ekran nazwy dnia tygodnia
Console.WriteLine("Dzień tygodnia: " + date.DayOfWeek);


//tworzenie łancuchów
string msgImplicityNull;
string msgExplicityNull = null;
string msgEmpty = string.Empty;
string msgInitiated = "Hello";
string pathWithEscapes = "c:\\programs\\app\\file.txt";
string pathWithoutEscapes = @"c:\programs\app\file.txt";
int counter = 6;
string msgEvaluation = $"Counter = {counter}";
char[] chars = { 'H', 'e', 'l', 'l', 'o' };
string msgFromCharArray = new string(chars);
String msgInitiatedByConstructor = new String(chars);

//Niezmienniczość łańcuchów
string a = "abcd";
string b = "efgh";
a += b;
Console.WriteLine(a.ToUpper());
Console.WriteLine(a);