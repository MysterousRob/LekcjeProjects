using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>
        {
            new Book("Ulysses", "James Joyce", 1922),
            new Book("Lolita", "Vladimir Nabokov", 1955),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925),
            new Book("In Search of Lost Time", "Marcel Proust", 1913)
        };

        // Sort authors alphabetically
        books.Sort((b1, b2) => b1.Author.CompareTo(b2.Author));
        foreach (var book in books)
        {
            Console.WriteLine(book.Author);
        }

        // Add favorite book
        books.Add(new Book("My Favorite Book", "Favorite Author", 2000));

        // Search books older than 100 years
        foreach (var book in books)
        {
            if (DateTime.Now.Year - book.YearPublished > 100)
                Console.WriteLine(book.Title);
        }

        // Remove the last book
        books.RemoveAt(books.Count - 1);

        // Display all books
        foreach (var book in books)
        {
            Console.WriteLine(book.Title);
        }
    }
}
