using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace chat_winForm.Registry
{
    /// <summary>
    /// ユーザー情報を提供するクラス
    /// </summary>
    class UserCredentialsProvider
    {
        private const String REGISTRY_SUB_KEY = @"chat-app\user";
        private const String USER_ID_NAME_KEY = "userIdName";
        private const String USER_NAME_KEY = "userName";
        private const String PASSWORD_KEY = "password";

        private const String ENCODE_KEY = @"ffffffawt89z@-0:A~W$t5raz;0349^q";
        private const String ENCODE_IV = @"SZDtyp0ioeawet%&";

        readonly static UserCredentialsProvider s_userCredentialsProvider = new UserCredentialsProvider();
        readonly static private RijndaelManaged s_rijndael = new RijndaelManaged();

        /// <summary>
        /// コンストラクタ（外部で使わない）
        /// </summary>
        private UserCredentialsProvider() { }

        /// <summary>
        /// UserCredentialsProviderのインスタンスを返す
        /// </summary>
        /// <returns>UserCredentialsProviderのインスタンス</returns>
        static public UserCredentialsProvider GetInstance()
        {
            return s_userCredentialsProvider;
        }

        /// <summary>
        /// ユーザーId (正確にはユーザーID名)
        /// </summary>
        public String UserIdName
        {
            get
            {
                return GetKeyValue(USER_ID_NAME_KEY);
            }
            set
            {
                SetKeyValue(USER_ID_NAME_KEY, value);
            }
        }

        /// <summary>
        /// ニックネーム（=ユーザー名）
        /// </summary>
        public String UserName
        {
            get
            {
                return GetKeyValue(USER_NAME_KEY);
            }
            set
            {
                SetKeyValue(USER_NAME_KEY, value);
            }
        }

        /// <summary>
        /// パースワード
        /// </summary>
        public String Password
        {
            get
            {
                return GetKeyValue(PASSWORD_KEY);
            }
            set
            {
                SetKeyValue(PASSWORD_KEY, value);
            }
        }

        /// <summary>
        /// 認証用トークン
        /// </summary>
        public String oauthToken { get; set; }

        public void AllDelete()
        {
            Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree(REGISTRY_SUB_KEY);
        }

        private void SetKeyValue(String keyName, String keyValue)
        {
            var regstryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGISTRY_SUB_KEY, true);

            try
            {
                var encodedValue = Encrypt(keyValue, ENCODE_IV, ENCODE_KEY);
                regstryKey.SetValue(keyName, encodedValue);
            }
            finally
            {
                regstryKey.Close();
            }
        }

        private String GetKeyValue(String keyName)
        {
            var regstryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGISTRY_SUB_KEY, false);

            try
            {
                var encodedValue = regstryKey.GetValue(keyName);
                if (encodedValue == null)
                    return null;
                else
                    return Decrypt(encodedValue.ToString(), ENCODE_IV, ENCODE_KEY);
            }
            finally
            {
                regstryKey.Close();
            }
        }

        private string Encrypt(string text, string iv, string key)
        {
            s_rijndael.KeySize = key.Length * 4;
            s_rijndael.Mode = CipherMode.CBC;
            s_rijndael.Padding = PaddingMode.PKCS7;

            s_rijndael.IV = Encoding.UTF8.GetBytes(iv);
            s_rijndael.Key = Encoding.UTF8.GetBytes(key);

            ICryptoTransform encryptor = s_rijndael.CreateEncryptor(s_rijndael.Key, s_rijndael.IV);

            byte[] encrypted;
            using (MemoryStream mStream = new MemoryStream())
            {
                using (CryptoStream ctStream = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(ctStream))
                    {
                        sw.Write(text);
                    }
                    encrypted = mStream.ToArray();
                }
            }
            return System.Convert.ToBase64String(encrypted);
        }

        private String Decrypt(string cipher, string iv, string key)
        {
            s_rijndael.KeySize = key.Length * 4;
            s_rijndael.Mode = CipherMode.CBC;
            s_rijndael.Padding = PaddingMode.PKCS7;

            s_rijndael.IV = Encoding.UTF8.GetBytes(iv);
            s_rijndael.Key = Encoding.UTF8.GetBytes(key);

            ICryptoTransform decryptor = s_rijndael.CreateDecryptor(s_rijndael.Key, s_rijndael.IV);

            string plain = string.Empty;
            using (MemoryStream mStream = new MemoryStream(
                System.Convert.FromBase64String(cipher)))
            {
                using (CryptoStream ctStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(ctStream))
                    {
                        plain = sr.ReadLine();
                    }
                }
            }
            return plain;
        }
    }
}
