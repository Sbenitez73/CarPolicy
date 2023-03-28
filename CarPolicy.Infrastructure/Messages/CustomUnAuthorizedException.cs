namespace CarPolicy.Infrastructure.Messages
{
    public class CustomUnAuthorizedException: ModelBaseException
    {
        public CustomUnAuthorizedException() : base() { }

        public CustomUnAuthorizedException(string message) : base(message) { }

        public CustomUnAuthorizedException(string message, Exception innerException) : base(message, innerException) { }

        public CustomUnAuthorizedException(ApplicationMessage message) : base(message) { }
    }
}
