using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace RiotCaller
{
    public class ApiUrl<T> where T : class
    {
        public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();
        
        public Object ResultData { get; set; }

        /// <summary>
        /// raw url 
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// url formatter 
        /// </summary>
        /// <param name="_suffix">
        /// </param>
        public ApiUrl(suffix _suffix)
        {
            Suffix = _suffix;
            Url = string.Format("https://{0}/{{region}}/v{1}/{2}/{3}",
                Suffix.GetApiType().GetValue(),
                Suffix.GetApiGrop().GetVersion(),
                Suffix.GetApiGrop(),
                Suffix.GetValue()
                );
        }

        /// <summary>
        /// suffixes may replace instead of CacheKey 
        /// </summary>
        public string CacheKey { get { return Suffix.ToString(); } }

        /// <summary>
        /// api urls 
        /// </summary>
        public suffix Suffix { get; private set; }
    }
}