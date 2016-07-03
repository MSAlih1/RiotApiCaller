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
using System.Linq;

namespace RiotCaller.Api
{
    public class NonStaticApi : INonStaticApi
    {
        public ApiCache Cache { get; private set; }

        public NonStaticApi(ApiCache _cache)
        {
            Cache = _cache;
        }

        public NonStaticApi()//only for test project
        {
        }

        public ChampionStatus GetChampionRotationById(region region, long championId)
        {
            RiotApiCaller<ChampionStatus> caller = new RiotApiCaller<ChampionStatus>(suffix.championRotationId);
            caller.AddParam(param.region, region);
            caller.AddParam(param.id, championId);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public ChampionRotation GetChampionRotation(region region, bool onlyFreeToPlay = true)
        {
            RiotApiCaller<ChampionRotation> caller = new RiotApiCaller<ChampionRotation>(suffix.championRotation);
            caller.AddParam(param.region, region);
            caller.AddParam(param.freeToPlay, onlyFreeToPlay);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public int GetChampionMasteryScore(long playerId, region region)
        {
            return new Summoner() { Id = playerId, Region = region }
             .GetChampionScore();
        }

        public List<ChampionMastery> GetChampionMasteryTop(long playerId, region region, int count = 3)
        {
            return new Summoner() { Id = playerId, Region = region }
             .GetChampionTop(count);
        }

        public ChampionMastery GetChampionMastery(long playerId, long championId, region region)
        {
            return new Summoner() { Id = playerId, Region = region }
               .GetChampionMastery(championId);
        }

        public List<ChampionMastery> GetChampionMasteries(long playerId, region region)
        {
            return new Summoner() { Id = playerId, Region = region }
              .GetChampionMasteries();
        }

        public FuturedGames GetFuturedGames(region region)
        {
            RiotApiCaller<FuturedGames> caller = new RiotApiCaller<FuturedGames>(suffix.featuredGames);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public RecentGames GetRecentGames(long summonerId, region region)
        {
            return new Summoner() { Id = summonerId, Region = region }
              .GetRecentGames();
        }

        public League GetLeague(long summonerId, region region)
        {
            return new Summoner() { Id = summonerId, Region = region }
            .GetLeague();
        }

        public List<List<League>> GetLeagues(List<long> summonerIds, region region)
        {
            //<=obligate
            RiotApiCaller<List<League>> caller = new RiotApiCaller<List<League>>(suffix.leagueByIds);
            caller.AddParam(param.summonerIds, summonerIds);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            return caller.Result;
        }

        public MatchDetail GetMatchDetail(long matchId, region region, bool includeTimeline = false)
        {
            RiotApiCaller<MatchDetail> caller = new RiotApiCaller<MatchDetail>(suffix.matchdetail);
            caller.AddParam(param.matchId, matchId);
            caller.AddParam(param.region, region);
            caller.AddParam(param.includeTimeline, includeTimeline);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public MatchList GetMatchList(long summonerId, region region, List<long> championIds = null,
            List<queue> queue = null, List<season> seasons = null, DateTime? beginTime = null, DateTime? endTime = null,
            int? beginIndex = null, int? endIndex = null)
        {
            return new Summoner() { Id = summonerId, Region = region }
            .GetMatchList(championIds, queue, seasons, beginTime, endTime, beginIndex, endIndex);
        }

        public Ranked GetStatsRanked(long summonerId, region region, season? season = null)
        {
            return new Summoner() { Id = summonerId, Region = region }
            .GetStatsRanked(season);
        }

        public Summary GetStatsSummary(long summonerId, region region, season? season = null)
        {
            return new Summoner() { Id = summonerId, Region = region }
           .GetStatsSummary(season);
        }

        public Summoner GetSummoner(string summonerName, region region)
        {
            List<Summoner> result = GetSummoners(new List<string>() { summonerName }, region);
            if (result.Count > 0)
                return result.FirstOrDefault();
            else
                return null;
        }

        public Summoner GetSummoner(long summonerId, region region)
        {
            List<Summoner> result = GetSummoners(new List<long>() { summonerId }, region);
            if (result.Count > 0)
                return result.FirstOrDefault();
            else
                return null;
        }

        public List<Summoner> GetSummoners(List<string> summonerNames, region region)
        {
            RiotApiCaller<Summoner> caller = new RiotApiCaller<Summoner>(suffix.summonerByname);
            caller.AddParam(param.summonerNames, summonerNames);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            caller.Result.ForEach(p => p.Region = region);
            return caller.Result;
        }

        public List<Summoner> GetSummoners(List<long> summonerIds, region region)
        {
            RiotApiCaller<Summoner> caller = new RiotApiCaller<Summoner>(suffix.summonerIds);
            caller.AddParam(param.summonerIds, summonerIds);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            caller.Result.ForEach(p => p.Region = region);
            return caller.Result;
        }

        public Team GetTeam(string teamName, region region)
        {
            List<Team> result = GetTeams(new List<string>() { teamName }, region);
            if (result.Count > 0)
                return result.FirstOrDefault();
            else
                return null;
        }

        public Team GetTeam(long teamId, region region)
        {
            List<Team> result = GetTeams(new List<long>() { teamId }, region);
            if (result.Count > 0)
                return result.FirstOrDefault();
            else
                return null;
        }

        public List<Team> GetTeams(List<string> teamNames, region region)
        {
            RiotApiCaller<Team> caller = new RiotApiCaller<Team>(suffix.teamByIds);
            caller.AddParam(param.teamIds, teamNames);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            return caller.Result.ToList();
        }

        public List<Team> GetTeams(List<long> teamIds, region region)
        {
            RiotApiCaller<List<Team>> caller = new RiotApiCaller<List<Team>>(suffix.teamIds);
            caller.AddParam(param.summonerIds, teamIds);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            //return caller.Result;//<== orginal
            return caller.Result.Select(p => p.FirstOrDefault()).ToList();//[CONFLICT] summoners' teams grouped but i combined to one list ( [A][1,2] + [B][1,2] = [C][1,2,3,4] )
        }
    }
}