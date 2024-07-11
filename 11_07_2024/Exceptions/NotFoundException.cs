namespace _11_07_2024.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() { }
        public NotFoundException(string message) : base(message) { }
    }
}
