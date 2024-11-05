using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string password = "password";
        ValidatePassword(password);
    }

    static void SetYourNewPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Hasło nie może być puste.");
        }
        if (password.Length < 10)
        {
            throw new FormatException("Hasło musi mieć co najmniej 10 znaków.");
        }
        if (!Regex.IsMatch(password, @"[A-Z]"))
        {
            throw new FormatException("Hasło musi zawierać przynajmniej jedną dużą literę.");
        }
        if (!Regex.IsMatch(password, @"[a-z]"))
        {
            throw new FormatException("Hasło musi zawierać przynajmniej jedną małą literę.");
        }
        if (!Regex.IsMatch(password, @"\d"))
        {
            throw new FormatException("Hasło musi zawierać przynajmniej jedną cyfrę.");
        }
        if (!Regex.IsMatch(password, @"[\W_]"))
        {
            throw new FormatException("Hasło musi zawierać przynajmniej jeden znak specjalny.");
        }

        Console.WriteLine("Hasło ustawione pomyślnie.");
    }

    static void ValidatePassword(string password)
    {
        try
        {
            SetYourNewPassword(password);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Błąd formatu: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
        }
    }
}
