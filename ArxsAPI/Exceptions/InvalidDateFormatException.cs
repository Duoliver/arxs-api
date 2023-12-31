namespace ArxsAPI.Exceptions
{
    public class InvalidDateFormatException : Exception
    {
        public InvalidDateFormatException()
        {
        }

        public InvalidDateFormatException(string message)
            : base(message)
        {
        }

        public InvalidDateFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}