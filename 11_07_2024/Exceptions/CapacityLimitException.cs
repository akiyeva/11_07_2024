namespace _11_07_2024.Exceptions
{
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException() { }
        public CapacityLimitException(string message) : base(message) { }
    }
}
