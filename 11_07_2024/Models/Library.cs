using _11_07_2024.Exceptions;

namespace _11_07_2024.Models;

public class Library
{
    public int BookLimit { get; set; }
    public List<Book> Books { get; set; }
    public Library(int bookLimit)
    {
        BookLimit = bookLimit;
    }
    public void AddBook(Book book)
    {
    }
    public Book GetBookById(int id)
    {
        foreach (Book book in Books)
        {
            if (book.Id == id)
                return book;
        }
        throw new NotFoundException();
    }
    public List<Book> GetAllBooks()
    {
        return Books;
    }
    public void RemoveBookById(int id)
    {
        foreach(Book book in Books)
        {
            if(book.Id == id)
            {
                for(int i = book.Id; i < Books.Count; i++)
                {
                    Books[i] = Books[i + 1];
                }
            }
        }
 
    }

}
