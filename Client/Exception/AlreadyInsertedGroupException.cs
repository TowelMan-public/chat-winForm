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
    class AlreadyInsertedGroupException : HttpException
    {
        public AlreadyInsertedGroupException() : base("You aleady joined chosen group") { }

        protected AlreadyInsertedGroupException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
