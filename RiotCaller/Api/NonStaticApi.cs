﻿using RiotCaller.Api.Cache;
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
        public NonStaticApi(ApiCache _cache)
        {
            Cache = _cache;
        }

        public NonStaticApi()//only for test project
        {
        }

        public ApiCache Cache { get; private set; }
        public List<ChampionMastery> GetChampionMasteries(long playerId, region region)
        {
            return new Summoner() { Id = playerId, Region = region }
              .GetChampionMasteries();
        }

        public ChampionMastery GetChampionMastery(long playerId, long championId, region region)
        {
            return new Summoner() { Id = playerId, Region = region }
               .GetChampionMastery(championId);
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

        public ChampionRotation GetChampionRotation(region region, bool onlyFreeToPlay = true, bool useCaching = false)
        {
            ChampionRotation val = Cache.Get<ChampionRotation>(region.ToString(), onlyFreeToPlay.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<ChampionRotation> caller = new RiotApiCaller<ChampionRotation>(suffix.championRotation);
            caller.AddParam(param.region, region);
            caller.AddParam(param.freeToPlay, onlyFreeToPlay);

            if (useCaching)
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(0, 0, 21, 0)));
            else
                caller.CreateRequest();

            return caller.Result.FirstOrDefault();
        }

        public ChampionStatus GetChampionRotationById(region region, long championId, bool useCaching = false)
        {
            ChampionStatus val = Cache.Get<ChampionStatus>(championId.ToString(), region.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<ChampionStatus> caller = new RiotApiCaller<ChampionStatus>(suffix.championRotationId);
            caller.AddParam(param.region, region);
            caller.AddParam(param.id, championId);

            if (useCaching)
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(0, 0, 21, 0)));
            else
                caller.CreateRequest();

            return caller.Result.FirstOrDefault();
        }
        public FuturedGames GetFuturedGames(region region)
        {
            RiotApiCaller<FuturedGames> caller = new RiotApiCaller<FuturedGames>(suffix.featuredGames);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public League GetLeague(long summonerId, region region, bool useCaching = false)
        {
            League val = Cache.Get<League>(summonerId.ToString(), region.ToString()); //cache getting
            if (val != null)
                return val;

            League data = new Summoner() { Id = summonerId, Region = region }
            .GetLeague();

            if (useCaching)
                Cache.AddOrUpdate(new cacheObject<League>(string.Join("+", typeof(League).ToString(), summonerId, region), data, new TimeSpan(0, 22, 0)));

            return data;
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

        public MatchDetail GetMatchDetail(long matchId, region region, bool includeTimeline = false, bool useCaching = false)
        {
            MatchDetail val = Cache.Get<MatchDetail>(matchId.ToString(), region.ToString(), includeTimeline.ToString()); //cache getting
            if (val != null)
                return val;

            RiotApiCaller<MatchDetail> caller = new RiotApiCaller<MatchDetail>(suffix.matchdetail);
            caller.AddParam(param.matchId, matchId);
            caller.AddParam(param.region, region);
            caller.AddParam(param.includeTimeline, includeTimeline);

            if (useCaching)
                Cache.AddOrUpdate(caller.CreateRequest(new System.TimeSpan(0, 0, 21, 0)));
            else
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

        public RecentGames GetRecentGames(long summonerId, region region, bool useCaching = false)
        {
            RecentGames val = Cache.Get<RecentGames>(summonerId.ToString(), region.ToString()); //cache getting
            if (val != null)
                return val;

            RecentGames data = new Summoner() { Id = summonerId, Region = region }
              .GetRecentGames();

            if (useCaching)
                Cache.AddOrUpdate(new cacheObject<RecentGames>(string.Join("+", typeof(RecentGames).ToString(), summonerId, region), data, new TimeSpan(0, 22, 0)));

            return data;
        }
        public Ranked GetStatsRanked(long summonerId, region region, season? season = null, bool useCaching = false)
        {
            Ranked val = Cache.Get<Ranked>(summonerId.ToString(), region.ToString(), season.ToString()); //cache getting
            if (val != null)
                return val;

            Ranked data = new Summoner() { Id = summonerId, Region = region }
            .GetStatsRanked(season);

            if (useCaching)
                Cache.AddOrUpdate(new cacheObject<Ranked>(string.Join("+", typeof(Ranked).ToString(), summonerId, region, season.ToString()), data, new TimeSpan(0, 22, 0)));

            return data;
        }

        public Summary GetStatsSummary(long summonerId, region region, season? season = null, bool useCaching = false)
        {
            Summary val = Cache.Get<Summary>(summonerId.ToString(), region.ToString(), season.ToString()); //cache getting
            if (val != null)
                return val;

            Summary data = new Summoner() { Id = summonerId, Region = region }
            .GetStatsSummary(season);

            if (useCaching)
                Cache.AddOrUpdate(new cacheObject<Summary>(string.Join("+", typeof(Summary).ToString(), summonerId, region, season.ToString()), data, new TimeSpan(0, 22, 0)));

            return data;
        }

        public Summoner GetSummoner(string summonerName, region region, bool useCaching = false)
        {
            Summoner val = Cache.Get<Summoner>(summonerName, region.ToString()); //cache getting
            if (val != null)
                return val;

            List<Summoner> result = GetSummoners(new List<string>() { summonerName }, region);
            if (result.Count > 0)
            {
                if (useCaching)
                    Cache.AddOrUpdate(new cacheObject<Summoner>(string.Join("+", typeof(Summoner).ToString(), summonerName, region), result.FirstOrDefault(), new TimeSpan(0, 22, 0)));

                return result.FirstOrDefault();
            }
            else
                return null;
        }

        public Summoner GetSummoner(long summonerId, region region, bool useCaching = false)
        {
            Summoner val = Cache.Get<Summoner>(summonerId.ToString(), region.ToString()); //cache getting
            if (val != null)
                return val;

            List<Summoner> result = GetSummoners(new List<long>() { summonerId }, region);
            if (result.Count > 0)
            {
                if (useCaching)
                    Cache.AddOrUpdate(new cacheObject<Summoner>(string.Join("+", typeof(Summoner).ToString(), summonerId.ToString(), region), result.FirstOrDefault(), new TimeSpan(0, 22, 0)));

                return result.FirstOrDefault();
            }
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

        public Team GetTeam(string teamName, region region, bool useCaching = false)
        {
            Team val = Cache.Get<Team>(teamName, region.ToString()); //cache getting
            if (val != null)
                return val;

            List<Team> result = GetTeams(new List<string>() { teamName }, region);
            if (result.Count > 0)
            {
                if (useCaching)
                    Cache.AddOrUpdate(new cacheObject<Team>(string.Join("+", typeof(Team).ToString(), teamName, region), result.FirstOrDefault(), new TimeSpan(0, 22, 0)));

                return result.FirstOrDefault();
            }
            else
                return null;
        }

        public Team GetTeam(long teamId, region region, bool useCaching = false)
        {
            Team val = Cache.Get<Team>(teamId.ToString(), region.ToString()); //cache getting
            if (val != null)
                return val;

            List<Team> result = GetTeams(new List<long>() { teamId }, region);
            if (result.Count > 0)
            {
                if (useCaching)
                    Cache.AddOrUpdate(new cacheObject<Team>(string.Join("+", typeof(Team).ToString(), teamId.ToString(), region), result.FirstOrDefault(), new TimeSpan(0, 22, 0)));

                return result.FirstOrDefault();
            }
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