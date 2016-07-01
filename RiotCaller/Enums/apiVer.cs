using RiotCaller.Attributes;

namespace RiotCaller.Enums
{
    /// <summary>
    /// api version controls 
    /// </summary>
    public enum apiVer
    {
        [Version(1.4)]
        summoner,

        [Version(2.5)]
        league,

        [Version(1.3)]
        stats,

        [Version(2.4)]
        team,

        [Version(2.2)]
        matchlist,

        [Version(2.2)]
        match,

        [Version(1.3)]
        game
    }
}