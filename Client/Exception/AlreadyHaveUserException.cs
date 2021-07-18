using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    /// <summary>
    /// 既に友達登録されているユーザーが不正に指定された
    /// </summary>
    [Serializable()]
    class AlreadyHaveUserException : HttpException
    {
        public AlreadyHaveUserException() : base("User chosen by you is alerady had by you") { }

        protected AlreadyHaveUserException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
