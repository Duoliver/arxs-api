namespace ArxsAPI.Exceptions
{
    public class TrackNotFoundException : Exception
    {
        public TrackNotFoundException()
        {
        }

        public TrackNotFoundException(string message)
            : base(message)
        {
        }

        public TrackNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}