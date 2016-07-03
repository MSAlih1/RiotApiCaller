namespace RiotCaller.Api.Service
{
    public interface IApiService
    {
        NonStaticApi Api { get; set; }
        StaticApi StaticApi { get; set; }
    }
}