namespace Kogane
{
    /// <summary>
    /// アセットの読み込み時にログ出力するために使用するクラス
    /// </summary>
    public sealed class AssetLoaderLogger
    {
        //================================================================================
        // デリゲート
        //================================================================================
        public delegate void Delegate( in AssetLoaderLoggerParameter parameter );

        //================================================================================
        // 変数(readonly)
        //================================================================================
        private readonly Delegate m_onStart;
        private readonly Delegate m_onSuccess;
        private readonly Delegate m_onFailure;
        private readonly Delegate m_onCancel;

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AssetLoaderLogger
        (
            Delegate onStart,
            Delegate onSuccess,
            Delegate onFailure,
            Delegate onCancel
        )
        {
            m_onStart   = onStart;
            m_onSuccess = onSuccess;
            m_onFailure = onFailure;
            m_onCancel  = onCancel;
        }

        /// <summary>
        /// アセットの読み込みを開始した時に呼び出します
        /// </summary>
        public void CallOnStart( in AssetLoaderLoggerParameter parameter )
        {
            m_onStart?.Invoke( parameter );
        }

        /// <summary>
        /// アセットの読み込みに成功した時に呼び出します
        /// </summary>
        public void CallOnSuccess( in AssetLoaderLoggerParameter parameter )
        {
            m_onSuccess?.Invoke( parameter );
        }

        /// <summary>
        /// アセットの読み込みに失敗した時に呼び出します
        /// </summary>
        public void CallOnFailure( in AssetLoaderLoggerParameter parameter )
        {
            m_onFailure?.Invoke( parameter );
        }

        /// <summary>
        /// アセットの読み込みにキャンセルした時に呼び出します
        /// </summary>
        public void CallOnCancel( in AssetLoaderLoggerParameter parameter )
        {
            m_onCancel?.Invoke( parameter );
        }
    }
}