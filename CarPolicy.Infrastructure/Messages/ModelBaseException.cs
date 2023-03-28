using System.Runtime.Serialization;

namespace CarPolicy.Infrastructure.Messages
{
    public class ModelBaseException: Exception
    {
        public ApplicationMessage ApplicationMessage { get; set; }

        public ApplicationMessage ExceptionMessage { get; set; }


        public ModelBaseException() : base() { }

        public ModelBaseException(string message) : base(message) { }

        public ModelBaseException(string message, Exception innerException) : base(message, innerException) { }

        public ModelBaseException(ApplicationMessage message) : base(message.Message, null)
        {
            this.ApplicationMessage = message;
        }

        public ModelBaseException(ApplicationMessage message, Exception innerException) : base(message.Message, innerException)
        {
            this.ApplicationMessage = message;
        }

        protected ModelBaseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
