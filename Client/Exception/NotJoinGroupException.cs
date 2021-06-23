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
    class NotJoinGroupException : HttpException
    {
        public NotJoinGroupException() : base("You don't join chosen group") { }

        protected NotJoinGroupException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
