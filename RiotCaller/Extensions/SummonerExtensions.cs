using RiotCaller.ApiEndPoints.Stats;
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
    }
}
