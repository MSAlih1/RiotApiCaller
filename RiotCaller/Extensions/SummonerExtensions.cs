using RiotCaller.ApiEndPoints.Stats;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller.ApiEndPoints.Summoner
{
    public static class SummonerExtensions
    {
        public static Summary GetStatsSummary(this Summoner sum, season season = season.SEASON2016)
        {
            ApiUrl<Summary> u = new ApiUrl<Summary>(suffix.statsSummary);
            u.AddParam(paramType.summonerId, sum.Id);
            u.AddParam(paramType.region, sum.Region);
            u.AddParam(paramType.season, season);
            u.CreateRequest();
            return u.Result.FirstOrDefault();
        }

        public static Ranked GetStatsRanked(this Summoner sum, season season = season.SEASON2016)
        {
            ApiUrl<Ranked> u = new ApiUrl<Ranked>(suffix.statsRanked);
            u.AddParam(paramType.summonerId, sum.Id);
            u.AddParam(paramType.region, sum.Region);
            u.AddParam(paramType.season, season);
            u.CreateRequest();
            return u.Result.FirstOrDefault();
        }

        public static List<Team.Team> GetTeams(this Summoner sum, season season = season.SEASON2016)
        {
            ApiUrl<List<Team.Team>> u = new ApiUrl<List<Team.Team>>(suffix.teamIds);
            u.AddParam(paramType.summonerIds, new List<long>() { sum.Id });
            u.AddParam(paramType.region, sum.Region);
            u.CreateRequest();
            return u.Result.FirstOrDefault();
        }
    }
}
