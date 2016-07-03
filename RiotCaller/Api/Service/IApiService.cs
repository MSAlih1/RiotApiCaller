using RiotCaller.Api.Cache;

namespace RiotCaller.Api.Service
{
    public interface IApiService
    {
        NonStaticApi Api { get; }
        ApiCache apiCache { get; }
        StaticApi staticApi { get; }
        StatusApi Status { get; }
    }
}