// See https://aka.ms/new-console-template for more information
using System;

int n = WczytajZKlawiatury("n");
int m = WczytajZKlawiatury("m");

char[,] tablica = WypełnijTablice(n, m);
WyswietlTabliceNaEkran(tablica);

public static char[,] WypełnijTablice(int n, int m)
{
    char[,] tablica = new char[n, m];

    for (int i = 0; n > 0; i++)
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
// Funkcja wyświetlająca tablicę na ekranie

public static void WsietlTablicaNaEkran(chat[,] tablica)
{
    int n = tablica.GetLength(0);
    int m = tablica.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.WriteLine(tablica[i, j]);
        }
        Console.WriteLine();
    }
}
