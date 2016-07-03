using System;

namespace RiotCaller.Api.Cache
{
    public class cacheObject<T> where T : class
    {
        public string PKey { get; set; }
        public T Obj { get; set; }

        public TimeSpan ExpiryTime { get; set; }//for cache objects

        public TimeSpan keysExpiryTime { get; set; }//for multiple keys

        public cacheObject(string key, T value, TimeSpan expiry)
        {
            PKey = key;
            Obj = value;
            ExpiryTime = expiry;
        }

        public cacheObject(string key, T value, TimeSpan expiry, TimeSpan forMultipleKeys)
        {
            PKey = key;
            Obj = value;
            ExpiryTime = expiry;
            keysExpiryTime = forMultipleKeys;
        }
    }
}