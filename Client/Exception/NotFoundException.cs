using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace chat_winForm.Client.Exception
{
    [Serializable()]
    class NotFoundException : HttpException
    {
        public NotFoundException(String message) : base(message) { }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }

		public String GetErrorFieldName()
		{
			//正規表現のパターン
			const String PATTERN_SIRING = "^(?<fieldName>.*) is not found$";

			//項目（ここではfieldName）を取得する
			var reg = new Regex(PATTERN_SIRING);
			var mat = reg.Match(this.Message);
			var fieldName = mat.Groups["fieldName"].Value;
			return fieldName;
		}

		public bool IsErrorFieldUserIdName()
		{
			return GetErrorFieldName().Equals("userIdName");
		}
	}
}
