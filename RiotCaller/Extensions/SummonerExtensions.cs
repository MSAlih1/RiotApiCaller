using RiotCaller.EndPoints.Game;
using RiotCaller.EndPoints.League;
using RiotCaller.EndPoints.MatchList;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller.ApiEndPoints
{
    public static class SummonerExtensions
    {
        public static RecentGames GetRecentGames(this Summoner sum)
        {
            RiotApiCaller<RecentGames> caller = new RiotApiCaller<RecentGames>(suffix.recentgames);
            caller.AddParam(param.summonerId, sum.Id);
            caller.AddParam(param.region, sum.Region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
        public static League GetLeague(this Summoner sum)
        {
            RiotApiCaller<League> caller = new RiotApiCaller<League>(suffix.leagueByIds);
            caller.AddParam(param.summonerIds, sum.Id);
            caller.AddParam(param.region, sum.Region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public static MatchList GetMatchList(this Summoner sum, List<long> _championIds = null,
            List<queue> _queue = null, List<season> _seasons = null, DateTime? _beginTime = null, DateTime? _endTime = null,
            int? _beginIndex = null, int? _endIndex = null)
        {
            RiotApiCaller<MatchList> u = new RiotApiCaller<MatchList>(suffix.matchlist);
            u.AddParam(param.summonerId, new List<long>() { sum.Id });
            u.AddParam(param.region, sum.Region);

            if (_championIds != null)
                u.AddParam(param.championIds, _championIds);
            else
                u.RemoveParam(param.championIds);

            if (_queue != null)
                u.AddParam(param.rankedQueues, _queue);
            else
                u.RemoveParam(param.rankedQueues);

            if (_seasons != null)
                u.AddParam(param.seasons, _seasons);
            else
                u.RemoveParam(param.seasons);

            if (_beginTime != null)
                u.AddParam(param.beginTime, _beginTime.Value);
            else
                u.RemoveParam(param.beginTime);

            if (_endTime != null)
                u.AddParam(param.endTime, _endTime.Value);
            else
                u.RemoveParam(param.endTime);

            if (_beginIndex != null)
                u.AddParam(param.beginIndex, _beginIndex.Value);
            else
                u.RemoveParam(param.beginIndex);

            if (_endIndex != null)
                u.AddParam(param.endIndex, _endIndex.Value);
            else
                u.RemoveParam(param.endIndex);

            u.CreateRequest();
            return u.Result.FirstOrDefault();
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
            caller.AddParam(param.summonerIds, sum.Id);
            caller.AddParam(param.region, sum.Region);
            caller.CreateRequest();
            //return caller.Result;//<== orginal
            return caller.Result.Select(p => p.FirstOrDefault()).ToList();//[CONFLICT] summoners' teams grouped but i combined to one list ( [A][1,2] + [B][1,2] = [C][1,2,3,4] )
        }
    }
}