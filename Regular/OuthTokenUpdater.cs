using chat_winForm.Client.Exception;
using chat_winForm.Forms.Commons;
using chat_winForm.Registry;
using chat_winForm.Service;
using System;
using System.Threading;
using System.Threading.Tasks;

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

        private static readonly UserCredentialsProvider userCredentialsProvider = UserCredentialsProvider.GetInstance();
        private static readonly OuthTokenUpdater outhTokenUpdater = new OuthTokenUpdater();

        private System.Threading.Timer timer;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private OuthTokenUpdater() { }

        /// <summary>
        /// OuthTokenUpdaterのインスタンスを取得する
        /// </summary>
        /// <returns>OuthTokenUpdaterのインスタンス</returns>
        public static OuthTokenUpdater GetInstance()
        {
            return outhTokenUpdater;
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~OuthTokenUpdater()
        {
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
                userCredentialsProvider.OauthToken =
                    await Task.Run(() => UserService.Login(userCredentialsProvider.UserIdName, userCredentialsProvider.Password));
            }
            catch (LoginException)
            {
                userCredentialsProvider.DeletePassword();
                CommonMessageBoxs.FailureUpdateOuthTokenMessageBox();
                Stop();
            }
            catch (Exception)
            {
                CommonMessageBoxs.UnexpectedErrorMessageBox();
            }
        }

        /// <summary>
        /// 定期実行をやめる
        /// </summary>
        public void Stop()
        {
            if (timer != null)
            {
                timer.Dispose();
            }
        }
    }
}
