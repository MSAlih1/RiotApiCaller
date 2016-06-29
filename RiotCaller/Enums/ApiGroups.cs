using static RiotCaller.EnumAttributes;

namespace RiotCaller
{
    public enum ApiGroup
    {
        [Version(1.4)]
        summoner,

        [Version(2.5)]
        league,

        [Version(1.3)]
        stats
    }
}