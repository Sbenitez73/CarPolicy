namespace CarPolicy.Infrastructure.Messages
{
    public class CustomNotFoundException: ModelBaseException
    {
        public CustomNotFoundException(ApplicationMessage message, Exception exception) : base(message, exception)
        {
        }

        public CustomNotFoundException(ApplicationMessage message) : base(message)
        {
        }

        public CustomNotFoundException(string message, Exception innerException) : base(message, innerException) { }

        public CustomNotFoundException() : base() { }

        public CustomNotFoundException(string message) : base(message) { }
    }
}
