namespace GameFramework.Item
{
    /// <summary>
    /// 
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// 
        /// </summary>
        int Id
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        string ItemAssetName
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        object Handle
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        IItemGroup ItemGroup
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        void OnInit(int itemId, string itemAssetName, IItemGroup itemGroup, bool isNewInstance, object userData);

        /// <summary>
        /// 
        /// </summary>
        void OnRecycle();

        /// <summary>
        /// 
        /// </summary>
        void OnShow(object userData);

        /// <summary>
        /// 
        /// </summary>
        void OnHide(bool isShutdown, object userData);

        /// <summary>
        /// 
        /// </summary>
        void OnUpdate(float elapseSeconds, float realElapseSeconds);
    }
}

