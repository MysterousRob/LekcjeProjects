using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Year: {Year}";
    }
}

public class Program
{
    public static void Main()
    {
        List<Book> books = new List<Book>();
        string command = "";

        while (command != "Q")
        {
            // Display menu
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Display all books");
            Console.WriteLine("3. Search books");
            Console.WriteLine("Q. Quit");
            Console.Write("Choose an option: ");
            command = Console.ReadLine().ToUpper();

            switch (command)
            {
                case "1":
                    AddBook(books);
                    break;
                case "2":
                    DisplayBooks(books);
                    break;
                case "3":
                    SearchBooks(books);
                    break;
                case "Q":
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    private static void AddBook(List<Book> books)
    {
        Console.Write("Enter the title of the book: ");
        string title = Console.ReadLine();

        Console.Write("Enter the author of the book: ");
        string author = Console.ReadLine();

        Console.Write("Enter the year of publication: ");
        int year;
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.Write("Invalid year. Please enter the publication year again: ");
        }

        Book newBook = new Book(title, author, year);
        books.Add(newBook);
        Console.WriteLine("The book has been added.");
    }
    private static void DisplayBooks(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the collection.");
            return;
        }

        Console.WriteLine("Would you like to sort the books by:\n1. Title\n2. Author\n3. Year");
        Console.Write("Choose an option: ");
        string sortChoice = Console.ReadLine();

        IEnumerable<Book> sortedBooks = sortChoice switch
        {
            "1" => books.OrderBy(b => b.Title),
            "2" => books.OrderBy(b => b.Author),
            "3" => books.OrderBy(b => b.Year),
            _ => books
        };

        Console.WriteLine("List of books:");
        foreach (var book in sortedBooks)
        {
            Console.WriteLine(book);
        }
    }
    private static void SearchBooks(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the collection.");
            return;
        }

        Console.WriteLine("Search books by:\n1. Title\n2. Author\n3. Year");
        Console.Write("Choose an option: ");
        string searchChoice = Console.ReadLine();

        Console.Write("Enter the search term: ");
        string searchTerm = Console.ReadLine().ToLower();

        IEnumerable<Book> foundBooks = searchChoice switch
        {
            "1" => books.Where(b => b.Title.ToLower().Contains(searchTerm)),
            "2" => books.Where(b => b.Author.ToLower().Contains(searchTerm)),
            "3" => books.Where(b => b.Year.ToString().Contains(searchTerm)),
            _ => Enumerable.Empty<Book>()
        };

        if (!foundBooks.Any())
        {
            Console.WriteLine("No matching books found.");
        }
        else
        {
            Console.WriteLine("Found books:");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
