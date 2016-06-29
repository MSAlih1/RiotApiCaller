using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.ApiEndPoints.Stats;
using RiotCaller.ApiEndPoints.Summoner;
using RiotCaller.ApiEndPoints.Team;
using RiotCaller.Enums;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class ApiUrlTest
    {
        long summonerId1 = long.Parse(ConfigurationSettings.AppSettings["summonerId1"]);
        long summonerId2 = long.Parse(ConfigurationSettings.AppSettings["summonerId2"]);

        string summonerName1 = ConfigurationSettings.AppSettings["summonerName1"];
        string summonerName2 = ConfigurationSettings.AppSettings["summonerName2"];

        string teamName1 = ConfigurationSettings.AppSettings["teamId1"];
        string teamName2 = ConfigurationSettings.AppSettings["teamId2"];

        [TestMethod]
        public void teamteamByIds()
        {
            ApiUrl<Team> u = new ApiUrl<Team>(suffix.teamByIds);
            u.AddParam(paramType.teamIds, new List<string>() { teamName1 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest();
            Assert.IsTrue(u.Result.Count > 0);
        }

        [TestMethod]
        public void teamteamIds()
        {
            ApiUrl<List<Team>> u = new ApiUrl<List<Team>>(suffix.teamIds);
            u.AddParam(paramType.summonerIds, new List<long>() { summonerId1, summonerId1 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest();
            Assert.IsTrue(u.Result.Count > 0);
        }

        [TestMethod]
        public void statsRanked()
        {
            ApiUrl<Ranked> u = new ApiUrl<Ranked>(suffix.statsRanked);
            u.AddParam(paramType.summonerId, 466244);
            u.AddParam(paramType.region, region.tr);
            u.AddParam(paramType.season, season.SEASON2016);
            u.CreateRequest();
            Assert.IsTrue(u.Result.Count > 0);
        }

        [TestMethod]
        public void statsSummary()
        {
            ApiUrl<Summary> u = new ApiUrl<Summary>(suffix.statsSummary);
            u.AddParam(paramType.summonerId, 466244);
            u.AddParam(paramType.region, region.tr);
            u.AddParam(paramType.season, season.SEASON2016);
            u.CreateRequest();
            Assert.IsTrue(u.Result.Count > 0);
        }

        [TestMethod]
        public void summonerByname()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerByname);
            u.AddParam(paramType.summonerNames, new List<string>() { summonerName1, summonerName1 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest();

            Assert.IsTrue(u.Result.Count > 0);
        }

        [TestMethod]
        public void summonerIds()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerIds);
            u.AddParam(paramType.summonerIds, new List<long>() { summonerId1, summonerId1 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest();
            Assert.IsTrue(u.Result.Count > 0);
        }
    }
}