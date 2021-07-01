using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    [Serializable()]
    class AlreadyUsedUserIdNameException : HttpException
    {
        public AlreadyUsedUserIdNameException() : base("This userIdName is already used") { }

        protected AlreadyUsedUserIdNameException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
