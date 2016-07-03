using System.Collections.Generic;

namespace RiotCaller.Api.Cache
{
    public interface IApiCache
    {
        void AddOrUpdate<T>(cacheObject<T> _object) where T : class;
        void AddWithMultipleKey<T>(List<string> keys, cacheObject<T> _object) where T : class;
        T Get<T>(params string[] pKey) where T : class;
        T GetMultipleKey<T>(string pKey) where T : class;
    }
}