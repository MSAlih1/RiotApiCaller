using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller.Api.Cache
{
    public class ApiCache : IApiCache
    {
        private ConcurrentDictionary<string, string> refCacheKey { get; set; } = new ConcurrentDictionary<string, string>();

        public ApiCache()
        {
        }

        public void AddWithMultipleKey<T>(List<string> keys, cacheObject<T> _object)
            where T : class
        {
            string val = "";
            foreach (var key in keys)
            {
                bool status = false;
                do
                {
                    status = refCacheKey.TryAdd(key.ToLower(), _object.PKey);
                    if (!status)//if already exists, firstly removes
                        refCacheKey.TryRemove(key, out val);
                }
                while (!status);
            }
            MemoryCache.Cache.Store(_object.PKey, _object, (int)_object.ExpiryTime.TotalMilliseconds);
        }

        public T GetMultipleKey<T>(string pKey)
            where T : class
        {
            string val = "";
            bool isExists = refCacheKey.TryGetValue(pKey.ToLower(), out val);//im not sure that
            if (isExists)
            {
                return Get<T>(val);
            }
            else
            {
                RemoveMultipleKey(val);
                return null;
            }
        }

        public void AddOrUpdate<T>(cacheObject<T> _object)
            where T : class
        {
            MemoryCache.Cache.Store(_object.PKey, _object, (int)_object.ExpiryTime.TotalMilliseconds);
        }

        public T Get<T>(params string[] _pKey)
            where T : class
        {
            string findkey = string.Format("{0}+{1}", typeof(T).ToString(), string.Join("+", _pKey));
            try
            {
                object val = MemoryCache.Cache.Get(findkey);
                return (val as cacheObject<T>).Obj;
            }
            catch (MemoryCache.MemoryCacheException ex)
            {
                RemoveMultipleKey(findkey);
                return null;
            }
        }

        private void RemoveMultipleKey(string pKey) //cleaning multiplekeys
        {
            var removeAll = refCacheKey.Where(p => p.Value == pKey).ToList();
            foreach (var item in removeAll)
            {
                string val2 = "";
                refCacheKey.TryRemove(item.Key, out val2);
            }
        }

        public void MemoryClear()//cleaning memory
        {
            MemoryCache.Cache.Flush();
            refCacheKey.Clear();
        }
    }
}