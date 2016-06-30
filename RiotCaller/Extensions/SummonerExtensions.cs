using RiotCaller.ApiEndPoints.Stats;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller.ApiEndPoints
{
    public static class SummonerExtensions
    {
        public static League GetLeague(this Summoner sum)
        {
            RiotApiCaller<List<League>> caller = new RiotApiCaller<List<League>>(suffix.leagueByIds);
            caller.AddParam(param.summonerIds, sum.Id);
            caller.AddParam(param.region, sum.Region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault().FirstOrDefault();
        }
        public static MatchList GetMatchList(this Summoner sum, List<long> _championIds = null,
            List<queue> _queue = null, List<season> _seasons = null, DateTime? _beginTime = null, DateTime? _endTime = null,
            int? _beginIndex = null, int? _endIndex = null)
        {
            RiotApiCaller<MatchList> caller = new RiotApiCaller<MatchList>(suffix.matchlistId);
            caller.AddParam(param.summonerId, new List<long>() { sum.Id });
            caller.AddParam(param.region, sum.Region);

            if (_championIds != null)
                caller.AddParam(param.championIds, _championIds);
            else
                caller.RemoveParam(param.championIds);

            if (_queue != null)
                caller.AddParam(param.rankedQueues, _queue);
            else
                caller.RemoveParam(param.rankedQueues);

            if (_seasons != null)
                caller.AddParam(param.seasons, _seasons);
            else
                caller.RemoveParam(param.seasons);

            if (_beginTime != null)
                caller.AddParam(param.beginTime, _beginTime.Value);
            else
                caller.RemoveParam(param.beginTime);

            if (_endTime != null)
                caller.AddParam(param.endTime, _endTime.Value);
            else
                caller.RemoveParam(param.endTime);

            if (_beginIndex != null)
                caller.AddParam(param.beginIndex, _beginIndex.Value);
            else
                caller.RemoveParam(param.beginIndex);

            if (_endIndex != null)
                caller.AddParam(param.endIndex, _endIndex.Value);
            else
                caller.RemoveParam(param.endIndex);

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public static Ranked GetStatsRanked(this Summoner sum, season? season = null)
        {
            RiotApiCaller<Ranked> caller = new RiotApiCaller<Ranked>(suffix.statsRanked);
            caller.AddParam(param.summonerId, sum.Id);
            caller.AddParam(param.region, sum.Region);
            if (season != null)
                caller.AddParam(param.season, season.Value);
            else
                caller.RemoveParam(param.season);

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public static Summary GetStatsSummary(this Summoner sum, season? season = null)
        {
            RiotApiCaller<Summary> caller = new RiotApiCaller<Summary>(suffix.statsSummary);
            caller.AddParam(param.summonerId, sum.Id);
            caller.AddParam(param.region, sum.Region);
            if (season != null)
                caller.AddParam(param.season, season.Value);
            else
                caller.RemoveParam(param.season);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public static List<Team> GetTeams(this Summoner sum)
        {
            RiotApiCaller<List<Team>> caller = new RiotApiCaller<List<Team>>(suffix.teamIds);
            caller.AddParam(param.summonerIds, new List<long>() { sum.Id });
            caller.AddParam(param.region, sum.Region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
    }
}