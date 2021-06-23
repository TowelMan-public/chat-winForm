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
    class LoginException : HttpException
    {
        public LoginException() : base("Error when login") { }

        protected LoginException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
