using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace chat_winForm.Client.Exception
{
    [Serializable()]
    class AlreadyHaveUserException : HttpException
    {
        public AlreadyHaveUserException() : base("User chosen by you is alerady had by you") { }

        protected AlreadyHaveUserException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
