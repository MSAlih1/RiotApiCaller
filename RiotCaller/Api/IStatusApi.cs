using System.Collections.Generic;
using RiotCaller.Api.Cache;
using RiotCaller.StatusEndPoints.Shards;

namespace RiotCaller.Api
{
    public interface IStatusApi
    {
        RiotApiCache Cache { get; set; }

        List<Shards> GetShards();
    }
}