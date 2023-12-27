namespace ArxsAPI.Responses
{
    public class Response
    {
        public string? Message { get; set; } 
        public bool IsSuccesful { get; set; }

        public Response()
        {
        }

        public Response(bool isSuccesful)
        {
            IsSuccesful = isSuccesful;
        }

        public Response(string message, bool isSuccesful)
        {
            Message = message;
            IsSuccesful = isSuccesful;
        }
    }
}