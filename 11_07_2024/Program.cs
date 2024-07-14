using _11_07_2024.Models;

namespace _11_07_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Library library = new Library(3);

                Book book1 = new Book("Book 1", 10.99m, "Author 1", 100, 5);
                Book book2 = new Book("Book 2", 15.99m, "Author 2", 200, 3);
                Book book3 = new Book("Book 3", 20.99m, "Author 3", 300, 2);

                library.AddBook(book1);
                library.AddBook(book2);
                library.AddBook(book3);

                book1.Sell();
                book1.ShowInfo();

                library.GetBookById(1).ShowInfo();

                library.RemoveBookById(1);

                library.GetAllBooks();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
