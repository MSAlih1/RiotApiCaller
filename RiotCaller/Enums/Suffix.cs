using static RiotCaller.EnumAttributes;

namespace RiotCaller
{
    /// <summary>
    /// suffixes may replace instead of CacheKey 
    /// </summary>
    public enum Suffix
    {
        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.summoner)]
        [Value("")]
        summonerNone,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.summoner)]
        [Value("by-name/{summonerNames}")]
        summonerByname,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.summoner)]
        [Value("{summonerIds}/name")]
        summonerName,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.summoner)]
        [Value("{summonerIds}")]
        summonerIds,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.summoner)]
        [Value("{summonerIds}/masteries")]
        summonerMasteries,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.summoner)]
        [Value("{summonerIds}/runes")]
        summonerRunes,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.league)]
        [Value("by-summoner/{summonerIds}")]
        leagueIds,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.league)]
        [Value("by-summoner/{summonerIds}/entry")]
        leagueEntry,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.league)]
        [Value("by-team/{teamIds}")]
        leagueTeamIds,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.league)]
        [Value("by-team/{teamIds}/entry")]
        leagueTeamEntries,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.league)]
        [Value("challenger")]
        leagueChallenger,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.league)]
        [Value("master")]
        leagueMaster,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.stats)]
        [Value("by-summoner/{summonerId}/ranked")]
        statsRanked,

        [ApiType(ApiType.nonStatic)]
        [ApiGrop(ApiGroup.stats)]
        [Value("by-summoner/{summonerId}/summary")]
        statsSummary
    }
}