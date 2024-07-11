namespace _11_07_2024.Models
{
    public abstract class Product
    {
        public int Id { get; protected set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalIncome { get; protected set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public abstract void Sell();
        public abstract void ShowInfo();

    }
}
