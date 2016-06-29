using static RiotCaller.EnumAttributes;

namespace RiotCaller
{
    /// <summary>
    /// api version controls 
    /// </summary>
    public enum apiGroup
    {
        [Version(1.4)]
        summoner,

        [Version(2.5)]
        league,

        [Version(1.3)]
        stats
    }
}