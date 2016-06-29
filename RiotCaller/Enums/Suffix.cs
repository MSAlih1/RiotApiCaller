using static RiotCaller.EnumAttributes;

namespace RiotCaller
{
    /// <summary>
    /// reference to api url 
    /// </summary>
    public enum suffix
    {
        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("?api_key={api_key}")]
        summonerNone,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("by-name/{summonerNames}?api_key={api_key}")]
        summonerByname,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}/name?api_key={api_key}")]
        summonerName,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}?api_key={api_key}")]
        summonerIds,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}/masteries?api_key={api_key}")]
        summonerMasteries,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}/runes?api_key={api_key}")]
        summonerRunes,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-summoner/{summonerIds}?api_key={api_key}")]
        leagueByIds,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-summoner/{summonerIds}/entry?api_key={api_key}")]
        leagueByIdsEntry,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-team/{teamIds}?api_key={api_key}")]
        leagueTeamByIds,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-team/{teamIds}/entry?api_key={api_key}")]
        leagueTeamByIdsEntries,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("challenger?api_key={api_key}")]
        leagueChallenger,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("master?api_key={api_key}")]
        leagueMaster,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.stats)]
        [Value("by-summoner/{summonerId}/ranked?api_key={api_key}&season={season}")]
        statsRanked,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.stats)]
        [Value("by-summoner/{summonerId}/summary?api_key={api_key}")]
        statsSummary,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.team)]
        [Value("by-summoner/{summonerIds}?api_key={api_key}")]
        teamIds,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.team)]
        [Value("team/{teamIds}?api_key={api_key}")]
        teamByIds
    }
}