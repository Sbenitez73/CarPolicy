namespace CarPolicy.Infrastructure.Messages
{
    public class ApplicationMessage
    {
        public ApplicationMessage(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public int Code { get; private set; }
        public string Message { get; private set; }
    }
}
