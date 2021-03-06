using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    /// <summary>
    /// グループに勧誘されていない
    /// </summary>
    [Serializable()]
    class NotInsertedGroupDesireException : HttpException
    {
        public NotInsertedGroupDesireException() : base("You don't join chosen group desire") { }

        protected NotInsertedGroupDesireException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
