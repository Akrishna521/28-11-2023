using System;
using System.Collections.Generic;

class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public bool IsAvailable { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book newBook)
    {
        books.Add(newBook);
    }

    public void ViewAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
    }

    public void SearchBookByld(int bookId)
    {
        var book = books.Find(b => b.BookId == bookId);

        if (book != null)
        {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void SearchBookByTitle(string title)
    {
        var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (book != null)
        {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        Library myLibrary = new Library();

        Book book1 = new Book { BookId = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", IsAvailable = true };
        Book book2 = new Book { BookId = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", IsAvailable = false };

        myLibrary.AddBook(book1);
        myLibrary.AddBook(book2);

        Console.WriteLine("All Books:");
        myLibrary.ViewAllBooks();

        Console.WriteLine("\nSearch by ID (BookId = 1):");
        myLibrary.SearchBookByld(1);

        Console.WriteLine("\nSearch by Title (Title = 'To Kill a Mockingbird'): ");
        myLibrary.SearchBookByTitle("To Kill a Mockingbird");
    }
}
