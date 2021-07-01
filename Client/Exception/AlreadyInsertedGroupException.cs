using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    [Serializable()]
    class AlreadyInsertedGroupException : HttpException
    {
        public AlreadyInsertedGroupException() : base("You aleady joined chosen group") { }

        protected AlreadyInsertedGroupException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
