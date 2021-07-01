using chat_winForm.Client.Exception;
using chat_winForm.Registry;
using chat_winForm.Service;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_winForm.Regular
{
    /// <summary>
    /// 認証用トークンを定期実行で更新するクラス
    /// </summary>
    class OuthTokenUpdater
    {
        /// <summary>
        /// 認証用トークンを更新する間隔
        /// </summary>
        const int PERIOD = 30 * 60 * 1000;

        static private UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();
        static private OuthTokenUpdater outhTokenUpdater = new OuthTokenUpdater();

        private System.Threading.Timer timer;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private OuthTokenUpdater() { }

        /// <summary>
        /// OuthTokenUpdaterのインスタンスを取得する
        /// </summary>
        /// <returns>OuthTokenUpdaterのインスタンス</returns>
        static public OuthTokenUpdater GetInstance()
        {
            return outhTokenUpdater;
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~OuthTokenUpdater(){
            Stop();
        }

        /// <summary>
        /// 定期実行を始める
        /// </summary>
        public void Start()
        {
            TimerCallback timerCallback = state =>
            {
                RunUpdae();
            };

            timer = new System.Threading.Timer(timerCallback, null, 0, PERIOD);
        }

        /// <summary>
        /// 定期事項の内容
        /// </summary>
        private async void RunUpdae()
        {
            try
            {
                var outhToken = await Task.Run(() => UserService.Login(userCredentialsProvider.UserIdName, userCredentialsProvider.Password));
                userCredentialsProvider.oauthToken = outhToken;
            }
            catch (LoginException)
            {
                userCredentialsProvider.DeletePassword();
                MessageBox.Show("認証の更新でエラーが発生しました。これは外部でパスワードが変更されたときにおこるエラーです。" +
                    "後でパスワードを再設定してください。",
                    "失敗",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("予期しないエラーが発生しました。これまでに行われた操作は一部、あるいはすべてが無効になっている可能性があります。" +
                        "この現象が続く場合は開発者に報告してください。",
                        "重大なエラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 定期実行をやめる
        /// </summary>
        public void Stop()
        {
            timer.Dispose();
        }
    }
}
