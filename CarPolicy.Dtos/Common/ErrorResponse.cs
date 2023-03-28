using System.Runtime.Serialization;

namespace CarPolicy.Dtos.Common
{
    [DataContract]
    public class ErrorResponse
    {
        public ErrorResponse( string message, int errorCode )
        {
            this.Message = message;
            this.ErrorCode = errorCode;
        }

        [DataMember( Name = "message" )]
        public string Message { get; set; }

        [DataMember(Name = "errorCode")]
        public int ErrorCode { get; set; }
    }
}
