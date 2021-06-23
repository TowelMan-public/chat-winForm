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
    class NotFoundException : HttpException
    {
        public NotFoundException(String message) : base(message) { }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
