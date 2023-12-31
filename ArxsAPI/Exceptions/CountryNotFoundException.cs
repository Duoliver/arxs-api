namespace ArxsAPI.Exceptions
{
    public class CountryNotFoundException : Exception
    {
        public CountryNotFoundException()
        {
        }

        public CountryNotFoundException(string message)
            : base(message)
        {
        }

        public CountryNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}