using ExampleProject2.Repositories;
using RiotCaller;
using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints;
using RiotCaller.EndPoints.Stats;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleProject2.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILolApi _lolapi) 
            : base(_lolapi)
        {
        }

        public ActionResult Index()
        {
            //////////////////////////////////////////////////

            //GetSummoner TYPE 1
            var summoner1 = LolApi.Api.GetSummoner("kesintisiz", region.tr);

            //GetSummoner TYPE 2
            var summoner2 = new RiotApiCaller<Summoner>(suffix.summonerByname);
            summoner2.AddParam(param.summonerNames, new List<string>() { "kesintisiz" });
            summoner2.AddParam(param.region, region.tr);
            summoner2.CreateRequest();
            ///////////////////////////////////////////////////

            //GetStatsRanked TYPE 1
            var ranked1 = LolApi.Api.GetStatsRanked(summoner1.Id, region.tr);

            //GetStatsRanked TYPE 2
            var ranked2 = new RiotApiCaller<Ranked>(suffix.statsRanked);
            ranked2.AddParam(param.summonerId, summoner1.Id);
            ranked2.AddParam(param.region, region.tr);
            ranked2.AddParam(param.season, season.SEASON2016);
            ranked2.CreateRequest();

            //GetStatsRanked TYPE 3
            var ranked3 = summoner1.GetStatsRanked();

            //GetStatsRanked TYPE 4
            var ranked4 = SummonerExtensions.GetStatsRanked(summoner1);
            ///////////////////////////////////////////////////

            ViewBag.Summoner = summoner1;
            ViewBag.RankedStat = ranked1;
            return View();
        }
    }
}