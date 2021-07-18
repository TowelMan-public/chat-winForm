using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace chat_winForm.Registry
{
    /// <summary>
    /// ユーザー情報を提供するクラス
    /// </summary>
    class UserCredentialsProvider
    {
        private const String REGISTRY_SUB_KEY = @"chat-app\user";
        private const String USER_ID_NAME_KEY = "userIdName";
        private const String PASSWORD_KEY = "password";

        private const String ENCODE_KEY = @"ffffffawt89z@-0:A~W$t5raz;0349^q";
        private const String ENCODE_IV = @"SZDtyp0ioeawet%&";

        static readonly UserCredentialsProvider s_userCredentialsProvider = new UserCredentialsProvider();
        private static readonly RijndaelManaged s_rijndael = new RijndaelManaged();

        /// <summary>
        /// コンストラクタ（外部で使わない）
        /// </summary>
        private UserCredentialsProvider() { }

        /// <summary>
        /// UserCredentialsProviderのインスタンスを返す
        /// </summary>
        /// <returns>UserCredentialsProviderのインスタンス</returns>
        public static UserCredentialsProvider GetInstance()
        {
            return s_userCredentialsProvider;
        }

        /// <summary>
        /// ユーザーId (正確にはユーザーID名)
        /// レジストリに保存される
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
        /// パースワード
        /// レジストリに保存される
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
        /// レジストリに保存されない
        /// </summary>
        public String OauthToken { get; set; }

        /// <summary>
        /// UserIdNameの値の削除
        /// </summary>
        public void DeleteUserIdName()
        {
            DeleteKeyValue(USER_ID_NAME_KEY);
        }

        /// <summary>
        /// Passwordの値の削除
        /// </summary>
        public void DeletePassword()
        {
            DeleteKeyValue(PASSWORD_KEY);
        }

        /// <summary>
        /// OuthTokenの値の削除
        /// </summary>
        public void DeleteOuthToken()
        {
            OauthToken = null;
        }

        /// <summary>
        /// キーの中身を削除する
        /// </summary>
        /// <param name="keyName">キー名</param>
        private void DeleteKeyValue(String keyName)
        {
            Microsoft.Win32.RegistryKey regstryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGISTRY_SUB_KEY, true);
            regstryKey.DeleteValue(keyName, false);
        }

        /// <summary>
        /// この機種に格納されているすべてのユーザーに関する情報を削除する
        /// </summary>
        public void AllDelete()
        {
            Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree(REGISTRY_SUB_KEY);
        }

        /// <summary>
        /// レジストリのキーの中に値を格納する
        /// </summary>
        /// <param name="keyName">キーの名前</param>
        /// <param name="keyValue">値</param>
        private void SetKeyValue(String keyName, String keyValue)
        {
            Microsoft.Win32.RegistryKey regstryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGISTRY_SUB_KEY, true);

            try
            {
                string encodedValue = Encrypt(keyValue, ENCODE_IV, ENCODE_KEY);
                regstryKey.SetValue(keyName, encodedValue);
            }
            finally
            {
                regstryKey.Close();
            }
        }

        /// <summary>
        /// キーの値を取得する
        /// </summary>
        /// <param name="keyName">キーの名前</param>
        /// <returns>キーの値</returns>
        private String GetKeyValue(String keyName)
        {
            Microsoft.Win32.RegistryKey regstryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGISTRY_SUB_KEY, false);

            try
            {
                object encodedValue = regstryKey.GetValue(keyName);
                if (encodedValue == null)
                {
                    return null;
                }
                else
                {
                    return Decrypt(encodedValue.ToString(), ENCODE_IV, ENCODE_KEY);
                }
            }
            finally
            {
                regstryKey.Close();
            }
        }
        /// <summary>
        /// 暗号化する
        /// </summary>
        /// <param name="text">暗号化する対象の生文字列</param>
        /// <param name="iv">暗号化に使うもの</param>
        /// <param name="key">暗号化キー</param>
        /// <returns>暗号化された文字列</returns>
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

        /// <summary>
        /// 復号化する
        /// </summary>
        /// <param name="cipher">暗号化された文字列</param>
        /// <param name="iv">暗号化に使うもの</param>
        /// <param name="key">暗号化キー</param>
        /// <returns>復号化された生文字列</returns>
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
