using System.Collections.Generic;

namespace RiotCaller.Api.Cache
{
    public interface IApiCache
    {
        void AddOrUpdate<T>(cacheObject<T> _object) where T : class;
        bool AddWithMultipleKey(string key, string OrginKey);
        void AddWithMultipleKey(List<string> keys, string OrginKey);
        T Get<T>(string PKey) where T : class;
        T Get<T>(params string[] _pKey) where T : class;
        T GetWithMultipleKey<T>(string pKey) where T : class;
        void MemoryClear();
    }
}