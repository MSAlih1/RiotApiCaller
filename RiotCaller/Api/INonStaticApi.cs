using RiotCaller.Api.Cache;
using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints.ChampionMastery;
using RiotCaller.EndPoints.ChampionRotation;
using RiotCaller.EndPoints.FuturedGames;
using RiotCaller.EndPoints.Game;
using RiotCaller.EndPoints.League;
using RiotCaller.EndPoints.Match;
using RiotCaller.EndPoints.MatchList;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;

namespace RiotCaller.Api
{
    public interface INonStaticApi
    {
        ApiCache Cache { get; }

        List<ChampionMastery> GetChampionMasteries(long playerId, region region);

        ChampionMastery GetChampionMastery(long playerId, long championId, region region);

        int GetChampionMasteryScore(long playerId, region region);

        List<ChampionMastery> GetChampionMasteryTop(long playerId, region region, int count = 3);

        ChampionRotation GetChampionRotation(region region, bool onlyFreeToPlay = true, bool useCaching = false);

        ChampionStatus GetChampionRotationById(region region, long championId, bool useCaching = false);

        FuturedGames GetFuturedGames(region region);

        League GetLeague(long summonerId, region region, bool useCaching = false);

        List<List<League>> GetLeagues(List<long> summonerIds, region region);

        MatchDetail GetMatchDetail(long matchId, region region, bool includeTimeline = false, bool useCaching = false);

        MatchList GetMatchList(long summonerId, region region, List<long> championIds = null, List<queue> queue = null, List<season> seasons = null, DateTime? beginTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? beginIndex = default(int?), int? endIndex = default(int?));

        RecentGames GetRecentGames(long summonerId, region region, bool useCaching = false);

        Ranked GetStatsRanked(long summonerId, region region, season? season = default(season?), bool useCaching = false);

        Summary GetStatsSummary(long summonerId, region region, season? season = default(season?), bool useCaching = false);

        Summoner GetSummoner(string summonerName, region region, bool useCaching = false);

        Summoner GetSummoner(long summonerId, region region, bool useCaching = false);

        List<Summoner> GetSummoners(List<string> summonerNames, region region);

        List<Summoner> GetSummoners(List<long> summonerIds, region region);

        Team GetTeam(string teamName, region region, bool useCaching = false);

        Team GetTeam(long teamId, region region, bool useCaching = false);

        List<Team> GetTeams(List<string> teamNames, region region);

        List<Team> GetTeams(List<long> teamIds, region region);
    }
}