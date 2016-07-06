using System;
using System.Collections.Generic;

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

        public cacheObject(cacheParam<T> pkeybuild, T value, TimeSpan expiry)
        {
            PKey = pkeybuild.ToString();
            Obj = value;
            ExpiryTime = expiry;
        }

        public cacheObject(List<String> pkeybuild, T value, TimeSpan expiry)
        {
            PKey = string.Join("+", pkeybuild).ToLower();
            Obj = value;
            ExpiryTime = expiry;
        }

        //public cacheObject(string key, T value, TimeSpan expiry, TimeSpan forMultipleKeys)
        //{
        //    PKey = key;
        //    Obj = value;
        //    ExpiryTime = expiry;
        //    keysExpiryTime = forMultipleKeys;
        //}

    }
    public class cacheParam<T> where T : class
    {
        string param = "";
        /// <summary>
        /// need for cache primary key generating
        /// </summary>
        /// <param name="parameters"></param>
        public cacheParam(params Object[] parameters)
        {
            param = string.Format("{0}+{1}", typeof(T).ToCacheParam(), string.Join("+", parameters));
        }
        public override string ToString()
        {
            return param.ToLower();
        }
    }
}