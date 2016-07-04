using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.Api.Cache
{
    public class RefCacheItem
    {
        public DateTime ExpiryTime { get; set; }
        public string OriginKey { get; set; }
        public RefCacheItem(TimeSpan ts,string refkeyValue)
        {
            ExpiryTime = DateTime.Now.Add(ts);
            OriginKey = refkeyValue;
        }
    }
}
