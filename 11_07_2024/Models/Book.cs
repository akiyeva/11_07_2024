using _11_07_2024.Exceptions;

namespace _11_07_2024.Models
{
    public class Book : Product
    {
        private static int _id = 1;
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string name, decimal price, string authorName, int pageCount) : base(name, price) 
        {
            Id = _id++;
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
        }
        public override void Sell()
        {
            if(Count == 0)
            {
                throw new ProductCountIsZeroException();
            }

            Count--;
            TotalIncome+=Price;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Author - {AuthorName}, {PageCount} pages.");
        }
    }
}
