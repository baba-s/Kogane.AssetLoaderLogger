namespace Kogane
{
    /// <summary>
    /// アセットの読み込み時にログ出力する時に引数に渡されるパラメータを管理する構造体
    /// </summary>
    public readonly struct AssetLoaderLoggerParameter
    {
        //================================================================================
        // プロパティ
        //================================================================================
        public bool   WithLog { get; }
        public string Path    { get; }

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AssetLoaderLoggerParameter
        (
            bool   withLog,
            string path
        )
        {
            WithLog = withLog;
            Path    = path;
        }
    }
}