using RiotCaller.Attributes;

namespace RiotCaller.Enums
{
    /// <summary>
    /// reference to api url 
    /// </summary>
    public enum suffix
    {
        /// <param name="region">
        /// Region 
        /// </param>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("?")]
        summonerNone,

        /// <summary>
        /// <param name="string[]"> summonerNames </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("by-name/{summonerNames}?")]
        summonerByname,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("{summonerIds}?")]
        summonerIds,

        /// <param name="region">
        /// Region 
        /// </param>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("{summonerIds}/masteries?")]
        summonerMasteries,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("{summonerIds}/runes?")]
        summonerRunes,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-summoner/{summonerIds}?")]
        leagueByIds,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-summoner/{summonerIds}/entry?")]
        leagueByIdsEntry,

        /// <summary>
        /// <param name="string[]"> teamIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-team/{teamIds}?")]
        leagueTeamByIds,

        /// <summary>
        /// <param name="string[]"> teamIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-team/{teamIds}/entry?")]
        leagueTeamByIdsEntries,

        /// <param name="region">
        /// Region 
        /// </param>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("challenger?")]
        leagueChallenger,

        /// <param name="region">
        /// Region 
        /// </param>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("master?")]
        leagueMaster,

        /// <summary>
        /// <param name="long"> summonerId </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.stats)]
        [Value("by-summoner/{summonerId}/ranked?&season={season}")]
        statsRanked,

        /// <summary>
        /// <param name="long"> summonerId </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.stats)]
        [Value("by-summoner/{summonerId}/summary?")]
        statsSummary,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.team)]
        [Value("by-summoner/{summonerIds}?")]
        teamIds,

        /// <summary>
        /// <param name="string[]"> teamIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.team)]
        [Value("team/{teamIds}?")]
        teamByIds,

        /// <summary>
        /// <param name="long"> summonerId </param>
        /// <param name="long[]"> championIds
        /// </param><param name="Queues[]"> rankedQueues </param>
        /// <param name="season[]"> seasons
        /// </param><param name="DatetTime"> beginTime </param>
        /// <param name="DatetTime"> endTime
        /// </param><param name="int"> beginIndex </param>
        /// <param name="int"> endIndex
        /// </param><param name="region"> Region </param>
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.matchlist)]
        [Value("by-summoner/{summonerId}?&championIds={championIds}&rankedQueues={rankedQueues}&seasons={seasons}&beginTime={beginTime}&endTime={endTime}&beginIndex={beginIndex}&endIndex={endIndex}")]
        matchlist,

        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.match)]
        [Value("{matchId}?&includeTimeline={includeTimeline}")]
        matchdetail,

        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.game)]
        [Value("by-summoner/{summonerId}/recent?")]
        recentgames,

        [ApiType(apiType.nonStatic)]//<==  don't need apiVerAttribute
        [Value("observer-mode/rest/featured?")]
        featuredGames,

        [ApiType(apiType.nonStatic)]//<==  don't need a apiVerAttribute
        [Value("championmastery/location/{platformId}/player/{playerId}/champions?")]
        championMasteries,

        [ApiType(apiType.nonStatic)]//<==  don't need a apiVerAttribute
        [Value("championmastery/location/{platformId}/player/{playerId}/score?")]
        championMasteryScore,

        [ApiType(apiType.nonStatic)]//<==  don't need a apiVerAttribute
        [Value("championmastery/location/{platformId}/player/{playerId}/topchampions?count={count}")]
        championMasteryTop,

        [ApiType(apiType.nonStatic)]//<==  don't need a apiVerAttribute
        [Value("championmastery/location/{platformId}/player/{playerId}/champion/{championId}?")]
        championMastery,

        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.championRotation)]
        [Value("champion?freeToPlay={freeToPlay}")]
        championRotation,

        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.championRotation)]
        [Value("champion/{id}?")]
        championRotationId,

        /////////////////////////////////////////////
        ///////////STATIC DATA
        /////////////////////////////////////////////


        /// <summary>
        /// static champion list url
        /// </summary>
        [ApiType(apiType.Static)]
        [apiVer(apiVer.champion)]
        [Value("?locale={locale}&champData={champData}&dataById=true")]
        champions,


        /// <summary>
        /// static get champion byId url
        /// </summary>
        [ApiType(apiType.Static)]
        [apiVer(apiVer.champion)]
        [Value("{id}?locale={locale}&champData={champData}")]
        championsById,


        /// <summary>
        /// static item list url
        /// </summary>
        [ApiType(apiType.Static)]
        [apiVer(apiVer.item)]
        [Value("?locale={locale}&itemListData={itemListData}")]
        items,

        /// <summary>
        /// static item
        /// </summary>
        [ApiType(apiType.Static)]
        [apiVer(apiVer.item)]
        [Value("{id}?locale={locale}&itemData={itemData}")]
        item,

        

        /// <summary>
        /// static item
        /// </summary>
        [ApiType(apiType.Static)]
        [apiVer(apiVer.language_strings)]
        [Value("?locale={locale}")]
        languageStrings,



        /// <summary>
        /// list of every languages
        /// </summary>
        [ApiType(apiType.Static)]
        [apiVer(apiVer.languages)]
        [Value("?")]
        languages
    }
}
