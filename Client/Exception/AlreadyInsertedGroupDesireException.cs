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
    class AlreadyInsertedGroupDesireException : HttpException
    {
        public AlreadyInsertedGroupDesireException() : base("User chosen by you aleady joined chosen group desire") { }

        protected AlreadyInsertedGroupDesireException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
