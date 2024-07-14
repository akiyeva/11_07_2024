using _11_07_2024.Exceptions;

namespace _11_07_2024.Models;

public class Library
{
    public int BookLimit { get; set; }
    private List<Book> Books { get; set; }
    public Library(int bookLimit)
    {
        BookLimit = bookLimit;
        Books = new List<Book>();
    }
    public void AddBook(Book book)
    {
        if (Books.Count >= BookLimit)
        {
            throw new CapacityLimitException("Cannot add more books, capacity limit reached.");
        }
        Books.Add(book);
    }
    public Book GetBookById(int id)
    {
        var book = Books.Find(b => b.Id == id);
        if (book == null)
        {
            throw new NotFoundException("Book with the specified ID not found.");
        }
        return book;
    }
    public List<Book> GetAllBooks()
    {
        return new List<Book>(Books);
    }
    public void RemoveBookById(int id)
    {
        var book = GetBookById(id);

        Books.Remove(book);
    }

}
