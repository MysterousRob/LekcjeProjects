using System;

class Program
{
    public static (int n, int m) WczytajZKlawiatury()
    {
        Console.Write("Podaj liczbę wierszy (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Podaj liczbę kolumn (m): ");
        int m = int.Parse(Console.ReadLine());
        return (n, m);
    }

    public static char[,] WypełnijTablice(int n, int m)
    {
        char[,] tablica = new char[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                {
                    tablica[i, j] = '#';
                }
                else
                {
                    tablica[i, j] = ' ';
                }
            }
        }

        return tablica;
    }
    public static void WyswietlTabliceNaEkran(char[,] tablica)
    {
        int n = tablica.GetLength(0);
        int m = tablica.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(tablica[i, j]);
            }
            Console.WriteLine(); 
        }
    }

    static void Main(string[] args)
    {

        var (n, m) = WczytajZKlawiatury();

        char[,] tablica = WypełnijTablice(n, m);

        WyswietlTabliceNaEkran(tablica);
    }
}
