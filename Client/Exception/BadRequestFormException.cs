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
    class BadRequestFormException : HttpException
    {
        public BadRequestFormException(String message) : base(message) { }

        protected BadRequestFormException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
