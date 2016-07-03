using RiotCaller.Api.Cache;
using RiotCaller.StatusEndPoints.Shards;
using System.Collections.Generic;

namespace RiotCaller.Api
{
    public interface IStatusApi
    {
        ApiCache Cache { get; }

        List<Shards> GetShards();
    }
}