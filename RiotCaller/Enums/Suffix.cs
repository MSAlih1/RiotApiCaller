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
        [Value("?api_key={api_key}")]
        summonerNone,

        /// <summary>
        /// <param name="string[]"> summonerNames </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("by-name/{summonerNames}?api_key={api_key}")]
        summonerByname,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("{summonerIds}?api_key={api_key}")]
        summonerIds,

        /// <param name="region">
        /// Region 
        /// </param>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("{summonerIds}/masteries?api_key={api_key}")]
        summonerMasteries,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.summoner)]
        [Value("{summonerIds}/runes?api_key={api_key}")]
        summonerRunes,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-summoner/{summonerIds}?api_key={api_key}")]
        leagueByIds,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-summoner/{summonerIds}/entry?api_key={api_key}")]
        leagueByIdsEntry,

        /// <summary>
        /// <param name="string[]"> teamIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-team/{teamIds}?api_key={api_key}")]
        leagueTeamByIds,

        /// <summary>
        /// <param name="string[]"> teamIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-team/{teamIds}/entry?api_key={api_key}")]
        leagueTeamByIdsEntries,

        /// <param name="region">
        /// Region 
        /// </param>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("challenger?api_key={api_key}")]
        leagueChallenger,

        /// <param name="region">
        /// Region 
        /// </param>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("master?api_key={api_key}")]
        leagueMaster,

        /// <summary>
        /// <param name="long"> summonerId </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.stats)]
        [Value("by-summoner/{summonerId}/ranked?api_key={api_key}&season={season}")]
        statsRanked,

        /// <summary>
        /// <param name="long"> summonerId </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.stats)]
        [Value("by-summoner/{summonerId}/summary?api_key={api_key}")]
        statsSummary,

        /// <summary>
        /// <param name="long[]"> summonerIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.team)]
        [Value("by-summoner/{summonerIds}?api_key={api_key}")]
        teamIds,

        /// <summary>
        /// <param name="string[]"> teamIds </param><param name="region"> Region </param> 
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.team)]
        [Value("team/{teamIds}?api_key={api_key}")]
        teamByIds,

        /// <summary>
        /// <param name="long"> summonerId </param><param name="long[]"> championIds
        /// </param><param name="Queues[]"> rankedQueues </param><param name="season[]"> seasons
        /// </param><param name="DatetTime"> beginTime </param><param name="DatetTime"> endTime
        /// </param><param name="int"> beginIndex </param><param name="int"> endIndex
        /// </param><param name="region"> Region </param>
        /// </summary>
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.matchlist)]
        [Value("by-summoner/{summonerId}?api_key={api_key}&championIds={championIds}&rankedQueues={rankedQueues}&seasons={seasons}&beginTime={beginTime}&endTime={endTime}&beginIndex={beginIndex}&endIndex={endIndex}")]
        matchlist,

        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.match)]
        [Value("{matchId}?api_key={api_key}&includeTimeline={includeTimeline}")]
        matchdetail,
    }
}