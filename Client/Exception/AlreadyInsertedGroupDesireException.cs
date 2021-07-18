using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    /// <summary>
    /// 既にグループに勧誘されている
    /// </summary>
    [Serializable()]
    class AlreadyInsertedGroupDesireException : HttpException
    {
        public AlreadyInsertedGroupDesireException() : base("User chosen by you aleady joined chosen group desire") { }

        protected AlreadyInsertedGroupDesireException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
