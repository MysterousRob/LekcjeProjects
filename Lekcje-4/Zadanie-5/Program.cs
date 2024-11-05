using System;
   
class Program {
    static void Main()
{
    try
    {
        DateTime currentDate = DateTime.Now;
        string formattedDate = FormatDate(currentDate);
        Console.WriteLine(formattedDate);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wystąpił błąd: {ex.Message}");
    }
}

static string FormatDate(DateTime date)
{
    // Zwraca sformatowany ciąg znaków z użyciem interpolacji
    return $"{date.Day}...{date.Month}...{date.Year}...{date.Hour}:{date.Minute}:{date.Second}...{date.DayOfWeek}";
}
}