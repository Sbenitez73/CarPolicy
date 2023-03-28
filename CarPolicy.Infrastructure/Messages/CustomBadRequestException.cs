namespace CarPolicy.Infrastructure.Messages
{
    public class CustomBadRequestException: ModelBaseException
    {
        public CustomBadRequestException(ApplicationMessage message, Exception exception) : base(message, exception)
        {
        }

        public CustomBadRequestException(ApplicationMessage message) : base(message)
        {
        }

        public CustomBadRequestException(string message, Exception innerException) : base(message, innerException) { }

        public CustomBadRequestException() : base() { }

        public CustomBadRequestException(string message) : base(message) { }
    }
}
