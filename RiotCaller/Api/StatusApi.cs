using RiotCaller.Api.Cache;
using RiotCaller.Enums;
using RiotCaller.StatusEndPoints.Shards;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller.Api
{
    public class StatusApi : IStatusApi
    {
        public ApiCache Cache { get; private set; }

        public StatusApi(ApiCache _cache)
        {
            Cache = _cache;
        }

        public StatusApi()//only for test project
        {
        }

        public List<Shards> GetShards()
        {
            RiotApiCaller<List<Shards>> caller = new RiotApiCaller<List<Shards>>(suffix.status);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
    }
}