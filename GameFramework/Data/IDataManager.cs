using System.Collections.Generic;

namespace GameFramework.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataManager
    {
        /// <summary>
        /// 
        /// </summary>
        int DataCount { get; }

        /// <summary>
        /// 
        /// </summary>
        T GetData<T>() where T : Data;

        /// <summary>
        /// 
        /// </summary>
        Data GetData(string name);

        /// <summary>
        /// 
        /// </summary>
        bool HasData<T>() where T : Data;

        /// <summary>
        /// 
        /// </summary>
        bool HasData(string name);

        /// <summary>
        /// 
        /// </summary>
        Data[] GetAllData();

        /// <summary>
        /// 
        /// </summary>
        void GetAllData(List<Data> result);

        /// <summary>
        /// 
        /// </summary>
        void AddData<T>() where T : Data;

        /// <summary>
        /// 
        /// </summary>
        void AddData(Data Data);

        /// <summary>
        /// 
        /// </summary>
        void RemoveData<T>() where T : Data;

        /// <summary>
        /// 
        /// </summary>
        void RemoveData(Data Data);

        /// <summary>
        /// 
        /// </summary>
        void InitAllData();

        /// <summary>
        /// 
        /// </summary>
        void PreLoadAllData();

        /// <summary>
        /// 
        /// </summary>
        void LoadAllData();

        /// <summary>
        /// 
        /// </summary>
        void UnLoadAllData();

    }
}


