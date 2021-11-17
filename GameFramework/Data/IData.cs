namespace GameFramework.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IData
    {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        void Init();

        /// <summary>
        /// 
        /// </summary>
        void Preload();

        /// <summary>
        /// 
        /// </summary>
        void Load();

        /// <summary>
        /// 
        /// </summary>
        void Unload();

        /// <summary>
        /// 
        /// </summary>
        void Shutdown();
    }
}

