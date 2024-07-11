namespace _11_07_2024.Exceptions
{
    public class ProductCountIsZeroException : Exception
    {
        public ProductCountIsZeroException() { }
        public ProductCountIsZeroException(string message) : base(message) { }
    }
}
