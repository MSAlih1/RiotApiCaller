using System.Collections.Generic;
using RiotCaller.Api.Cache;
using RiotCaller.StatusEndPoints.Shards;

namespace RiotCaller.Api
{
    public interface IStatusApi
    {
        ApiCache Cache { get; }

        List<Shards> GetShards();
    }
}