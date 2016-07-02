namespace RiotCaller
{
    public interface IApiService
    {
        NonStaticApi Api { get; set; }
        StaticApi StaticApi { get; set; }
    }
}