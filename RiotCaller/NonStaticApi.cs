using RiotCaller.ApiEndPoints.Stats;
using RiotCaller.ApiEndPoints.Summoner;
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

    }
}