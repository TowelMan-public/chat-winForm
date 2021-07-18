using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Web;

namespace chat_winForm.Client.Exception
{
    /// <summary>
    /// 指定された項目の値が存在しない。見つからない。
    /// </summary>
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
            Regex reg = new Regex(PATTERN_SIRING);
            Match mat = reg.Match(Message);
            string fieldName = mat.Groups["fieldName"].Value;
            return fieldName;
        }

        public bool IsErrorFieldUserIdName()
        {
            return GetErrorFieldName().Equals("userIdName");
        }
    }
}
