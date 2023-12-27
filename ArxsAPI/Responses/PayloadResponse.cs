namespace ArxsAPI.Responses
{
    public class PayloadResponse<T> : Response
    {
        public T? Payload { get; set; }

        public PayloadResponse() : base()
        {
        }

        public PayloadResponse(string message, bool isSuccesful)
            : base(message, isSuccesful)
        {
        }

        public PayloadResponse(string message, bool isSuccesful, T payload)
            : base(message, isSuccesful)
        {
            Payload = payload;
        }

        public PayloadResponse(T payload)
            : base(true)
        {
            Payload = payload;
        }
    }
}