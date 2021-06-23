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
    class NotHaveUserException : HttpException
    {
        public NotHaveUserException() : base("User chosen by you is not had") { }

        protected NotHaveUserException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
