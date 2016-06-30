using RiotCaller;

namespace ExampleProject1.Repositories
{
    public interface ILolApi
    {
        NonStaticApi Api { get; }
        StaticApi StaticApi { get; }
    }
}