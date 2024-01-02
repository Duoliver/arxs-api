namespace ArxsAPI.Exceptions
{
    public class ManufacturerNotFoundException : Exception
    {
        public ManufacturerNotFoundException()
        {
        }

        public ManufacturerNotFoundException(string message)
            : base(message)
        {
        }

        public ManufacturerNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}