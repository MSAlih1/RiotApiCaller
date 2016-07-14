using RiotCaller.Api.Cache;
using RiotCaller.NonStaticEndPoints.CurrentGame;

namespace RiotCaller.Api.Service
{
    public interface IApiService
    {
        NonStaticApi Api { get; }
        ApiCache apiCache { get; }
        StaticApi staticApi { get; }
        StatusApi Status { get; }

        void Smartproperty(CurrentGame c);
    }
}