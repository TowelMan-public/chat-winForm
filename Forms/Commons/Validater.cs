using System;

namespace chat_winForm.Forms.Commons
{
    /// <summary>
    /// Formクラスでバリデーションチェックをするためのクラス。
    /// ErrorProviderコントロールを使用している前提。
    /// メソッドチェーン形式
    /// </summary>
    class Validater
    {
        private readonly String Value;
        private String errorMessage;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value">バリデーションチェック対象の文字列</param>
        public Validater(String value)
        {
            Value = value;
            errorMessage = null;
        }

        /// <summary>
        /// 空っぽはだめ（未入力等）
        /// </summary>
        /// <returns>自分自身</returns>
        public Validater NotBlank()
        {
            if (errorMessage == null)
            {
                if (Value == null || Value == "")
                {
                    errorMessage = "空っぽはだめです。何か入力してください。";
                }
            }
            return this;
        }

        /// <summary>
        /// 最大文字数の指定
        /// </summary>
        /// <param name="max">最大の文字数</param>
        /// <returns>自分自身</returns>
        public Validater MaxString(int max)
        {
            if (errorMessage == null)
            {
                if (Value.Length > max)
                {
                    errorMessage = $"{max}文字以内で入力してください。";
                }
            }
            return this;
        }

        /// <summary>
        /// 整数であることのチェック
        /// </summary>
        /// <returns>自分自身</returns>
        public Validater IntType()
        {
            if (errorMessage == null)
            {
                if (int.TryParse(Value, out _))
                {
                    errorMessage = "整数を入力してください";
                }
            }
            return this;
        }

        /// <summary>
        /// このクラスの終着点。
        /// ErrorProviderコントロール向けのエラーメッセージを返す。
        /// </summary>
        /// <returns>エラーがあれば一番最初に引っかかったエラーメッセージ。なければnull。</returns>
        public String getErrorMessage()
        {
            return errorMessage;
        }
    }
}