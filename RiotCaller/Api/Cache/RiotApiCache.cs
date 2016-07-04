using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller.Api.Cache
{

    public class ApiCache : IApiCache
    {
        private ConcurrentDictionary<string, RefCacheItem> refCacheKey { get; set; } = new ConcurrentDictionary<string, RefCacheItem>();

        public ApiCache() { }

        /// <summary>
        /// reference keys adding
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keys"></param>
        /// <param name="_object"></param>
        public void AddWithMultipleKey(List<string> keys, string OrginKey)
        {
            foreach (var key in keys)//multiple keys one value
            {
                while (!AddWithMultipleKey(key, OrginKey)) ;//if false try remove again
            }
            RemoveExpiredItems();
        }

        /// <summary>
        /// multiple key one value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="_object"></param>
        /// <returns></returns>
        public bool AddWithMultipleKey(string key, string OrginKey)
        {
            bool status = refCacheKey.TryAdd(key, new RefCacheItem(new TimeSpan(0, 22, 0), OrginKey));//adding reference key
            if (!status)//if already exists, firstly removes and set false for check again
                RemoveWithRefKey(key);
            return status;
        }

        /// <summary>
        /// cleaning expired reference keys
        /// </summary>
        private void RemoveExpiredItems()
        {
            var expiredList = refCacheKey.Where(p => p.Value.ExpiryTime < DateTime.Now);
            foreach (var item in expiredList)
                RemoveWithRefKey(item.Key);
        }

        /// <summary>
        /// getting data with multiple key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pKey"></param>
        /// <returns></returns>
        public T GetWithMultipleKey<T>(string pKey)
            where T : class
        {
            RemoveExpiredItems();//checking refkey expiry
            RefCacheItem data;
            bool isExists = refCacheKey.TryGetValue(pKey.ToLower(), out data);
            if (isExists)
            {

                return Get<T>(data.OriginKey);//orginkey searching in cache memory
            }
            else
            {
                if (data != null)
                    RemoveWithOrginKey(data.OriginKey);//if data not available, find reference keys and remove all
                return null;
            }
        }


        /// <summary>
        /// rrefkey with primary keys
        /// </summary>
        /// <param name="PKey"></param>
        private void RemoveWithRefKey(string PKey)
        {
            RefCacheItem val2;
            refCacheKey.TryRemove(PKey, out val2);
        }

        /// <summary>
        /// cleaning multiplekeys with orgin keys
        /// </summary>
        /// <param name="OrginKey"></param>
        private void RemoveWithOrginKey(string OrginKey)
        {
            var removeAll = refCacheKey.Where(p => p.Value.OriginKey == OrginKey);
            foreach (var item in removeAll)
                RemoveWithRefKey(item.Key);
        }
        //////////////////////////////////////////


        //////////////////////////////////////////
        /// <summary>
        /// adding new cache to memory
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_object"></param>
        public void AddOrUpdate<T>(cacheObject<T> _object)
            where T : class
        {
            MemoryCache.Cache.Store(_object.PKey, _object, (int)_object.ExpiryTime.TotalMilliseconds);
        }

        /// <summary>
        /// get data from cachememory
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_pKey"></param>
        /// <returns></returns>
        public T Get<T>(params string[] _pKey)
            where T : class
        {
            string findkey = string.Format("{0}+{1}", typeof(T).ToString(), string.Join("+", _pKey));
            try
            {
                return Get<T>(findkey);
            }
            catch (MemoryCache.MemoryCacheException ex)
            {
                RemoveWithOrginKey(findkey);
                return null;
            }
        }
        /// <summary>
        /// get with single key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PKey"></param>
        /// <returns></returns>
        public T Get<T>(string PKey)
            where T : class
        {
            object val = MemoryCache.Cache.Get(PKey);
            return (val as cacheObject<T>).Obj;
        }

        /// <summary>
        /// cache cleans
        /// </summary>
        public void MemoryClear()//cleaning memory
        {
            MemoryCache.Cache.Flush();
            refCacheKey.Clear();
        }
    }
}