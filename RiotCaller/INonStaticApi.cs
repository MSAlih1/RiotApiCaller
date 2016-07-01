using System;
using System.Collections.Generic;
using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints.League;
using RiotCaller.EndPoints.Match;
using RiotCaller.EndPoints.MatchList;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;

namespace RiotCaller
{
    public interface INonStaticApi
    {
        League GetLeague(long _summonerId, region _region);
        List<List<League>> GetLeagues(List<long> _summonerIds, region _region);
        MatchDetail GetMatchDetail(long _matchId, region _region, bool includeTimeline = false);
        MatchList GetMatchList(long _summonerId, region _region, List<long> _championIds = null, List<queue> _queue = null, List<season> _seasons = null, DateTime? _beginTime = default(DateTime?), DateTime? _endTime = default(DateTime?), int? _beginIndex = default(int?), int? _endIndex = default(int?));
        Ranked GetStatsRanked(long summonerId, region region, season? season = default(season?));
        Summary GetStatsSummary(long summonerId, region region, season? season = default(season?));
        Summoner GetSummoner(string summonerName, region region);
        Summoner GetSummoner(long summonerId, region region);
        List<Summoner> GetSummoners(List<string> summonerNames, region region);
        List<Summoner> GetSummoners(List<long> summonerIds, region region);
        Team GetTeam(string teamName, region region);
        Team GetTeam(long teamId, region region);
        List<Team> GetTeams(List<string> teamNames, region region);
        List<Team> GetTeams(List<long> teamIds, region region);
    }
}