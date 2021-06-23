using chat_winForm.Client.Exception;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace chat_winForm.Client
{
	/// <summary>
	/// RestTemplateクラスのエラーハンドリングクラス。
	/// </summary>
	/// <see cref="RestTemplate"/>
	class RestTemplateErrorHandler
    {
		static readonly private RestTemplateErrorHandler s_RestTemplateErrorHandler = new RestTemplateErrorHandler();

		/// <summary>
		/// RestTemplateErrorHandlerのインスタンスを返す。
		/// </summary>
		/// <returns>RestTemplateErrorHandlerのインスタンス</returns>
		static public RestTemplateErrorHandler GetInstance()
        {
			return s_RestTemplateErrorHandler;

		}

		/// <summary>
		/// 使わない
		/// </summary>
		private RestTemplateErrorHandler() { }

		/// <summary>
		/// エラーハンドリングをするところ。（正確にはエラーかどうかを検証し、エラーであった場合は適切な例外を投げるところ）
		/// </summary>
		/// <param name="jsonString">JSON形式の文字列のレスポンスボディー</param>
		/// <param name="httpStatusCode">Httpコード</param>
		public void CheckErrorAndThrows(String jsonString, HttpStatusCode httpStatusCode)
        {
            if (HasError(httpStatusCode))
            {
				var errorResponse = ParseJson(jsonString);
                ThrowsException(errorResponse, httpStatusCode);

            }
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="httpStatusCode">Httpコード</param>
		/// <returns>エラーがあ有ればtrue, 無ければfalse</returns>
		private bool HasError(HttpStatusCode httpStatusCode)
        {
			//4xxシリーズと5xxシリーズをエラーとする
			return ((int)httpStatusCode) >= 400;

		}

		/// <summary>
		/// 適した例外を投げる
		/// </summary>
		/// <param name="errorResponse">エラーレスポンスボディー</param>
		/// <param name="httpStatusCode">Httpコード</param>
		private void ThrowsException(ErrorResponse errorResponse, HttpStatusCode httpStatusCode)
        {
			//各種具体的にわかる例外を投げる・分別ができないときは他のやつ投げる
			switch (errorResponse.ErrorCode)
			{
				case "NotFoundException":
					throw new NotFoundException(errorResponse.Message);
				case "LoginException":
					throw new LoginException();
				case "AlreadyHaveUserException":
					throw new AlreadyHaveUserException();
				case "AlreadyInsertedGroupDesireException":
					throw new AlreadyInsertedGroupDesireException();
				case "AlreadyInsertedGroupException":
					throw new AlreadyInsertedGroupException();
				case "AlreadyUsedUserIdNameException":
					throw new AlreadyUsedUserIdNameException();
				case "NotHaveUserException":
					throw new NotHaveUserException();
				case "NotInsertedGroupDesireException":
					throw new NotInsertedGroupDesireException();
				case "NotJoinGroupException":
					throw new NotJoinGroupException();
				case "BadRequestFormException":
					throw new BadRequestFormException(errorResponse.Message);
				default:
					if (httpStatusCode.Equals(HttpStatusCode.Unauthorized))
						throw new InvalidLoginException();
					else
						throw new HttpException();
			}
		}

		/// <summary>
		/// JSON形式のレスポンスボディーをErrorResponseに変換する。（解析の役割）
		/// </summary>
		/// <param name="jsonString">JSON形式のレスポンスボディー</param>
		/// <returns>エラーレスポンス</returns>
		private ErrorResponse ParseJson(String jsonString)
        {
			try
			{
				var jsonSerializerSettings = new JsonSerializerSettings
				{
					ContractResolver = new DefaultContractResolver
					{
						NamingStrategy = new CamelCaseNamingStrategy()
					}
				};
				return JsonConvert.DeserializeObject<ErrorResponse>(jsonString, jsonSerializerSettings);
			}
			//例外が長るときは指定された文字列がjson出ないときのみであるため、握りつぶせる。（サーバエラー発生時は必ずjsonになる。）
            catch (System.Exception)
            {
				return null;
            }
		}

		/// <summary>
		/// エラーレスポンス
		/// </summary>
		public class ErrorResponse
		{
			public String ErrorCode { get; set; }
			public String Message { get; set; }
		}
    }
}
