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
        [Value("")]
        summonerNone,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("by-name/{summonerNames}")]
        summonerByname,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}/name")]
        summonerName,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}")]
        summonerIds,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}/masteries")]
        summonerMasteries,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.summoner)]
        [Value("{summonerIds}/runes")]
        summonerRunes,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-summoner/{summonerIds}")]
        leagueIds,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-summoner/{summonerIds}/entry")]
        leagueEntry,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-team/{teamIds}")]
        leagueTeamIds,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("by-team/{teamIds}/entry")]
        leagueTeamEntries,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("challenger")]
        leagueChallenger,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.league)]
        [Value("master")]
        leagueMaster,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.stats)]
        [Value("by-summoner/{summonerId}/ranked")]
        statsRanked,

        [ApiType(apiType.nonStatic)]
        [ApiGrop(apiGroup.stats)]
        [Value("by-summoner/{summonerId}/summary")]
        statsSummary
    }
}