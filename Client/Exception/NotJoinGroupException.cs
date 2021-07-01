using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    [Serializable()]
    class NotJoinGroupException : HttpException
    {
        public NotJoinGroupException() : base("You don't join chosen group") { }

        protected NotJoinGroupException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
