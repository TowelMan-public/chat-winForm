using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    class InvalidLoginException : HttpException
    {
        public InvalidLoginException() : base("You have not login or you have to login one more") { }

        protected InvalidLoginException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
