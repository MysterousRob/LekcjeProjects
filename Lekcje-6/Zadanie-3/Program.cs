using System;

class Appearance
{
    // Właściwości wyglądu
    public string EyesColor { get; set; }
    public string HairColor { get; set; }
    public bool HasFreckles { get; set; }

    // Konstruktor
    public Appearance(string eyesColor, string hairColor, bool hasFreckles)
    {
        EyesColor = eyesColor;
        HairColor = hairColor;
        HasFreckles = hasFreckles;
    }

    // Wyświetlanie informacji o wyglądzie
    public override string ToString()
    {
        return $"Oczy: {EyesColor}, Włosy: {HairColor}, Piegi: {(HasFreckles ? "Tak" : "Nie")}";
    }
}

class Person
{
    // Właściwości klasy Person
    public string Name { get; set; }
    public Appearance Appearance { get; set; } // Asocjacja do klasy Appearance

    // Konstruktor
    public Person(string name, Appearance appearance)
    {
        Name = name;
        Appearance = appearance;
    }

    // Wyświetlanie informacji o osobie
    public override string ToString()
    {
        return $"{Name}, Wygląd: {(Appearance != null ? Appearance.ToString() : "Brak informacji")}";
    }
}

// Testowanie
class Program
{
    static void Main(string[] args)
    {
        // Tworzenie wyglądu
        Appearance appearance = new Appearance("Niebieskie", "Brązowe", true);

        // Tworzenie osoby z wyglądem
        Person person = new Person("Anna", appearance);

        // Wyświetlanie informacji o osobie
        Console.WriteLine(person);
    }
}
