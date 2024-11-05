
enum DayOfTheWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

void PrintDayInfo(DayOfTheWeek day)
{

    string dayType = (day == DayOfTheWeek.Saturday || day == DayOfTheWeek.Sunday) ? "weekend" : "dzień roboczy";

    Console.WriteLine($"Dzień: {day}, Numer dnia: {(int)day}, Typ: {dayType}");
}

// Przykładowe wywołania
PrintDayInfo(DayOfTheWeek.Monday);    
//PrintDayInfo(DayOfTheWeek.Saturday);  
