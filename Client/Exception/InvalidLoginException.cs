using System.Runtime.Serialization;
using System.Web;

namespace chat_winForm.Client.Exception
{
    /// <summary>
    /// 認証エラー（認証用トークンが不正・再ログインが必要）
    /// </summary>
    class InvalidLoginException : HttpException
    {
        public InvalidLoginException() : base("You have not login or you have to login one more") { }

        protected InvalidLoginException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
