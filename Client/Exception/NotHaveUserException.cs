using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    [Serializable()]
    class NotHaveUserException : HttpException
    {
        public NotHaveUserException() : base("User chosen by you is not had") { }

        protected NotHaveUserException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
