using RiotCaller.Api.Cache;

namespace RiotCaller.Api.Service
{
    /// <summary>
    /// # use InSingletonScope with Ninject # 
    /// </summary>
    public class ApiService : IApiService
    {
        public StatusApi Status { get; set; } //in the future
        public NonStaticApi Api { get; set; }
        public StaticApi StaticApi { get; set; }
        public RiotApiCache Cache { get; set; } //in the future

        public ApiService()
        {
            Cache = new RiotApiCache();
            Api = new NonStaticApi(Cache);
            StaticApi = new StaticApi(Cache);
        }
    }
}