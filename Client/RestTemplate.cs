using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace chat_winForm.Client
{
    /// <summary>
    /// 外部WebAPIを呼ぶのを楽にするクラス。
    /// </summary>
    class RestTemplate
    {
        static readonly private RestTemplate s_RestTemplate = new RestTemplate();
        static readonly private HttpClient s_httpClient = new HttpClient(
            new HttpClientHandler
            {
                UseProxy = false
            });
        static readonly private RestTemplateErrorHandler s_RestTemplateErrorHandler = RestTemplateErrorHandler.GetInstance();

        const String OUTH_HTTP_HEADER_NAME = @"X-AUTH-TOKEN";
        const String Content_Type = "application/json";

        /// <summary>
        /// RestTemplateのインスタンスを返す。
        /// </summary>
        /// <returns>RestTemplateのインスタンス</returns>
        static public RestTemplate GetInstance()
        {
            return s_RestTemplate;

        }

        /// <summary>
        /// 使わない
        /// </summary>
        private RestTemplate()
        {
           
        }

        /// <summary>
        /// ログインされているときにGETメソッドを呼ぶ
        /// </summary>
        /// <typeparam name="Paramater">DTOクラス（パラメター）</typeparam>
        /// <typeparam name="Responce">レスポンスクラス</typeparam>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="url">APiのURL</param>
        /// <param name="paramaters">DTOクラス（パラメター）</param>
        /// <returns>レスポンスクラスに指定された型のレスポンス</returns>
        public Responce GetHttpMethodWhenLogined<Paramater,Responce>(String outhToken, String url, Paramater paramaters)
        {
            var requestParamaterUrl = CreateRequestParamaterUrl(paramaters);
            var request = new HttpRequestMessage(HttpMethod.Get, url + requestParamaterUrl);
            request.Headers.Add(OUTH_HTTP_HEADER_NAME, outhToken);

            var responseTask = s_httpClient.SendAsync(request);
            var response = responseTask.Result;
            var responseJsonString = response.Content.ReadAsStringAsync().Result;

            s_RestTemplateErrorHandler.CheckErrorAndThrows(responseJsonString, response.StatusCode);

            return JsonStringToObject<Responce>(responseJsonString);
        }

        /// <summary>
        /// ログインされているときにPOSTメソッドを呼ぶ
        /// </summary>
        /// <typeparam name="Paramater">DTOクラス（パラメター）</typeparam>
        /// <param name="outhToken">認証用トークン</param>
        /// <param name="url">APiのURL</param>
        /// <param name="paramaters">DTOクラス（パラメター）</param>
        public void PostHttpMethodWhenLogined<Paramater>(String outhToken, String url, Paramater paramaters)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add(OUTH_HTTP_HEADER_NAME, outhToken);

            var jsonString = ObjectToJsonString(paramaters);
            request.Content = new StringContent(jsonString, Encoding.UTF8, Content_Type);

            var responseTask = s_httpClient.SendAsync(request);
            var response = responseTask.Result;
            var responseJsonString = response.Content.ReadAsStringAsync().Result;

            s_RestTemplateErrorHandler.CheckErrorAndThrows(responseJsonString, response.StatusCode);
        }

        /// <summary>
        /// ログインされてないときのPOSTメソッドの呼び出し
        /// </summary>
        /// <typeparam name="Paramater">DTOクラス（パラメター）</typeparam>
        /// <param name="url">APiのURL</param>
        /// <param name="paramaters">DTOクラス（パラメター）</param>
        public void PostHttpMethod<Paramater>(String url, Paramater paramaters)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);

            var jsonString = ObjectToJsonString(paramaters);
            request.Content = new StringContent(jsonString, Encoding.UTF8, Content_Type);

            var responseTask = s_httpClient.SendAsync(request);
            var response = responseTask.Result;
            var responseJsonString = response.Content.ReadAsStringAsync().Result;

            s_RestTemplateErrorHandler.CheckErrorAndThrows(responseJsonString, response.StatusCode);
        }

        /// <summary>
        /// ログインされてないときのPOSTメソッドの呼び出し（ログイン時専用）
        /// </summary>
        /// <typeparam name="Paramater">DTOクラス（パラメター）</typeparam>
        /// <param name="url">APiのURL</param>
        /// <param name="paramaters">DTOクラス（パラメター）</param>
        /// <returns>文字列（認証用トークン）</returns>
        public String PostHttpMethodForLogin<Paramater>(String url, Paramater paramaters)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);

            var jsonString = ObjectToJsonString(paramaters);
            request.Content = new StringContent(jsonString, Encoding.UTF8, Content_Type);

            var responseTask = s_httpClient.SendAsync(request);
            var response = responseTask.Result;
            var responseJsonString = response.Content.ReadAsStringAsync().Result;

            s_RestTemplateErrorHandler.CheckErrorAndThrows(responseJsonString, response.StatusCode);

            return responseJsonString;
        }

        /// <summary>
        /// パラメータURLの作成
        /// </summary>
        /// <typeparam name="Paramater">DTOクラス（パラメター）</typeparam>
        /// <param name="paramaters">DTOクラス（パラメター）</param>
        /// <returns>パラメータURL</returns>
        private String CreateRequestParamaterUrl<Paramater>(Paramater paramaters)
        { 
            var requestParamaterUrl = new StringBuilder();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Paramater, Dictionary<String, Object> >();
            });
            var mapper = config.CreateMapper();
            
            var paramatersMap = mapper.Map< Dictionary<String, Object> >(paramaters);
            foreach(var pair in paramatersMap)
            {
                requestParamaterUrl.Append($",{pair.Key}={pair.Value}");
            }

            if (requestParamaterUrl.Length == 0)
                return "";
            else
            {
                requestParamaterUrl.Remove(0,1);
                return "?" + requestParamaterUrl.ToString();
            }
        }

        /// <summary>
        /// JSON文字列から指定されたクラスに変換する
        /// </summary>
        /// <typeparam name="ObjectType">変換したいクラスの型</typeparam>
        /// <param name="jsonString">JSON文字列</param>
        /// <returns>指定されたクラス</returns>
        private ObjectType JsonStringToObject<ObjectType>(String jsonString)
        {
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };

            return JsonConvert.DeserializeObject<ObjectType>(jsonString, jsonSerializerSettings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="ObjectType">JSON文字列に変換したいクラスの型</typeparam>
        /// <param name="objectClass">クラス</param>
        /// <returns>JSON文字列</returns>
        private String ObjectToJsonString<ObjectType>(ObjectType objectClass)
        {
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };

            return JsonConvert.SerializeObject(objectClass, jsonSerializerSettings);
        }
    }
}