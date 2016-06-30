using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints.League;
using RiotCaller.EndPoints.Match;
using RiotCaller.EndPoints.MatchList;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller
{
    public class NonStaticApi
    {
        public MatchDetail GetMatchDetail(long _matchId, region _region, bool includeTimeline = false)
        {
            RiotApiCaller<MatchDetail> caller = new RiotApiCaller<MatchDetail>(suffix.matchdetail);
            caller.AddParam(param.matchId, _matchId);
            caller.AddParam(param.region, _region);
            caller.AddParam(param.includeTimeline, includeTimeline);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public League GetLeague(long _summonerId, region _region)
        {
            List<League> result = GetLeagues(new List<long>() { _summonerId }, _region).FirstOrDefault();
            if (result.Count > 0)
                return result.FirstOrDefault();
            else
                return null;
        }

        public List<List<League>> GetLeagues(List<long> _summonerIds, region _region)
        {
            RiotApiCaller<List<League>> caller = new RiotApiCaller<List<League>>(suffix.leagueByIds);
            caller.AddParam(param.summonerIds, _summonerIds);
            caller.AddParam(param.region, _region);
            caller.CreateRequest();
            return caller.Result;
        }

        public MatchList GetMatchList(long _summonerId, region _region, List<long> _championIds = null,
            List<queue> _queue = null, List<season> _seasons = null, DateTime? _beginTime = null, DateTime? _endTime = null,
            int? _beginIndex = null, int? _endIndex = null)
        {
            RiotApiCaller<MatchList> u = new RiotApiCaller<MatchList>(suffix.matchlist);
            u.AddParam(param.summonerId, new List<long>() { _summonerId });
            u.AddParam(param.region, _region);

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

        public Ranked GetStatsRanked(long summonerId, region region, season? season = null)
        {
            RiotApiCaller<Ranked> caller = new RiotApiCaller<Ranked>(suffix.statsRanked);
            caller.AddParam(param.summonerId, summonerId);
            caller.AddParam(param.region, region);
            if (season != null)
                caller.AddParam(param.season, season.Value);
            else
                caller.RemoveParam(param.season);

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public Summary GetStatsSummary(long summonerId, region region, season? season = null)
        {
            RiotApiCaller<Summary> caller = new RiotApiCaller<Summary>(suffix.statsSummary);
            caller.AddParam(param.summonerId, summonerId);
            caller.AddParam(param.region, region);
            if (season != null)
                caller.AddParam(param.season, season.Value);
            else
                caller.RemoveParam(param.season);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
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
            RiotApiCaller<Summoner> caller = new RiotApiCaller<Summoner>(suffix.summonerByname);
            caller.AddParam(param.summonerNames, summonerIds);
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