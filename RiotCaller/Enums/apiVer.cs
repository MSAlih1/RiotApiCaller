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
        game,

        [Version(1.2)]
        championRotation,

        //////////////////////
        //////STATIC DATA
        //////////////////////



        /// <summary>
        /// static api get champions list url (needs improve)
        /// </summary>
        [Version(1.2)]
        champion,
        [Version(1.2)]
        item,
        [Version(1.2)]
        language_strings,
        [Version(1.2)]
        languages,
        [Version(1.2)]
        map,
        [Version(1.2)]
        mastery,
        [Version(1.2)]
        realm,
        /// <summary>
        /// static-data getrunes
        /// </summary>
        [Version(1.2)]
        rune,
        [Version(1.2)]
        summoner_spell,
        [Version(1.2)]
        versions
    }
}