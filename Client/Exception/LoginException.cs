using System;
using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    /// <summary>
    /// ログインでエラーが発生した。
    /// </summary>
    [Serializable()]
    class LoginException : HttpException
    {
        public LoginException() : base("Error when login") { }

        protected LoginException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
