
namespace GameFramework.Data
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Data : IData
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this.GetType().ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void Init();

        /// <summary>
        /// 
        /// </summary>
        public abstract void Preload();

        /// <summary>
        /// 
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// 
        /// </summary>
        public abstract void Unload();

        /// <summary>
        /// 
        /// </summary>
        public abstract void Shutdown();

    }
}

