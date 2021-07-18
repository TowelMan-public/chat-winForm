using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    /// <summary>
    /// 指定したユーザーが友達でない
    /// </summary>
    [Serializable()]
    class NotHaveUserException : HttpException
    {
        public NotHaveUserException() : base("User chosen by you is not had") { }

        protected NotHaveUserException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
