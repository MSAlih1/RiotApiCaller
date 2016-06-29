using RiotCaller.ApiEndPoints.Stats;
using RiotCaller.ApiEndPoints.Summoner;
using RiotCaller.ApiEndPoints.Team;
using RiotCaller.Enums;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller
{
    public class NonStaticApi
    {

        public Summoner GetSummoner(string summonerName, region region = region.tr)
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerByname);
            u.AddParam(paramType.summonerNames, new List<string>() { summonerName });
            u.AddParam(paramType.region, region);
            u.CreateRequest();
            u.Result.FirstOrDefault().Region = region;
            return u.Result.FirstOrDefault();
        }

        public Summoner GetSummoner(long summonerId, region region = region.tr)
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerByname);
            u.AddParam(paramType.summonerNames, new List<long>() { summonerId });
            u.AddParam(paramType.region, region);
            u.CreateRequest();
            u.Result.FirstOrDefault().Region = region;
            return u.Result.FirstOrDefault();
        }

        public List<Summoner> GetSummoners(List<string> summonerNames, region region = region.tr)
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerByname);
            u.AddParam(paramType.summonerNames, summonerNames);
            u.AddParam(paramType.region, region);
            u.CreateRequest();
            u.Result.ForEach(p => p.Region = region);
            return u.Result;
        }

        public List<Summoner> GetSummoners(List<long> summonerIds, region region = region.tr)
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerByname);
            u.AddParam(paramType.summonerNames, summonerIds);
            u.AddParam(paramType.region, region);
            u.CreateRequest();
            u.Result.ForEach(p => p.Region = region);
            return u.Result;
        }

        public Summary GetStatsSummary(long summonerId, season season = season.SEASON2016, region region = region.tr)
        {
            ApiUrl<Summary> u = new ApiUrl<Summary>(suffix.statsSummary);
            u.AddParam(paramType.summonerId, summonerId);
            u.AddParam(paramType.region, region);
            u.AddParam(paramType.season, season);
            u.CreateRequest();
            return u.Result.FirstOrDefault();
        }

        public Summary GetStatsRanked(long summonerId, season season = season.SEASON2016, region region = region.tr)
        {
            ApiUrl<Summary> u = new ApiUrl<Summary>(suffix.statsRanked);
            u.AddParam(paramType.summonerId, summonerId);
            u.AddParam(paramType.region, region);
            u.AddParam(paramType.season, season);
            u.CreateRequest();
            return u.Result.FirstOrDefault();
        }

        public Team GetTeam(string teamName, season season = season.SEASON2016, region region = region.tr)
        {
            ApiUrl<Team> u = new ApiUrl<Team>(suffix.teamByIds);
            u.AddParam(paramType.teamIds, new List<string>() { teamName });
            u.AddParam(paramType.region, region);
            u.CreateRequest();
            return u.Result.FirstOrDefault();
        }

        public Team GetTeam(long teamId, season season = season.SEASON2016, region region = region.tr)
        {
            ApiUrl<List<Team>> u = new ApiUrl<List<Team>>(suffix.teamIds);
            u.AddParam(paramType.summonerIds, new List<long>() { teamId });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest();
            return u.Result.FirstOrDefault().FirstOrDefault();
        }


        public List<Team> GetTeams(List<string> teamNames, season season = season.SEASON2016, region region = region.tr)
        {
            ApiUrl<Team> u = new ApiUrl<Team>(suffix.teamByIds);
            u.AddParam(paramType.teamIds, teamNames);
            u.AddParam(paramType.region, region);
            u.CreateRequest();
            return u.Result.ToList();
        }

        public List<Team> GetTeams(List<long> teamIds, season season = season.SEASON2016, region region = region.tr)
        {
            ApiUrl<List<Team>> u = new ApiUrl<List<Team>>(suffix.teamIds);
            u.AddParam(paramType.summonerIds, teamIds);
            u.AddParam(paramType.region, region);
            u.CreateRequest();
            //return u.Result.ToList();//<== orginal
            return u.Result.Select(p => p.FirstOrDefault()).ToList();//[CONFLICT] summoners' teams grouped but i combined to one list ( [A][1,2] + [B][1,2] = [C][1,2,3,4] )
        }

    }
}