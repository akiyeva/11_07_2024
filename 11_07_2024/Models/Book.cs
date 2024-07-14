using _11_07_2024.Exceptions;

namespace _11_07_2024.Models
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string name, decimal price, string authorName, int pageCount, int count)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
            Count = count;
        }
        public override void Sell()
        {
            if (Count == 0)
            {
                throw new ProductCountIsZeroException("The book count is zero. Cannot sell.");
            }

            Count--;
            TotalIncome += Price;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Author: {AuthorName}, Price: {Price}, Pages: {PageCount}, Count: {Count}");
        }
    }
}
