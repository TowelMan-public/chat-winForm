using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    [Serializable()]
    class BadRequestFormException : HttpException
    {
        public BadRequestFormException(String message) : base(message) { }

        protected BadRequestFormException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
