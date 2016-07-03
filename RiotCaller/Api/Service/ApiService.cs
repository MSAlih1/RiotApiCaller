using RiotCaller.Api.Cache;

namespace RiotCaller.Api.Service
{
    /// <summary>
    /// # use InSingletonScope with Ninject # 
    /// </summary>
    public class ApiService : IApiService
    {
        public StatusApi Status { get; private set; }
        public NonStaticApi Api { get; private set; }
        public StaticApi staticApi { get; private set; }
        public ApiCache apiCache { get; private set; }

        public ApiService()
        {
            apiCache = new ApiCache();
            Api = new NonStaticApi(apiCache);
            staticApi = new StaticApi(apiCache);
            Status = new StatusApi(apiCache);
        }
    }
}