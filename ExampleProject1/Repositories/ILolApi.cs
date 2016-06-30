using RiotCaller;

namespace ExampleProject2.Repositories
{
    public interface ILolApi
    {
        NonStaticApi Api { get; }
        StaticApi StaticApi { get; }
    }
}