using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.ApiEndPoints.Stats;
using RiotCaller.ApiEndPoints.Summoner;
using RiotCaller.ApiEndPoints.Team;
using RiotCaller.Enums;
using System.Collections.Generic;

namespace RiotCaller.Tests
{
    [TestClass]
    public class ApiUrlTest
    {
        [TestMethod]
        public void leagueTeamByIds()
        {
            ApiUrl<Team> u = new ApiUrl<Team>(suffix.teamByIds);
            u.AddParam(paramType.teamIds, new List<string>() { "TEAM-6e7878e0-31a6-11e6-b7db-d4ae527241a0" });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void leagueTeamIds()
        {
            ApiUrl<List<Team>> u = new ApiUrl<List<Team>>(suffix.teamIds);
            u.AddParam(paramType.summonerIds, new List<long>() { 466244 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void statsRanked()
        {
            ApiUrl<Ranked> u = new ApiUrl<Ranked>(suffix.statsRanked);
            u.AddParam(paramType.summonerId, 466244);
            u.AddParam(paramType.region, region.tr);
            u.AddParam(paramType.season, season.SEASON2016);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void statsSummary()
        {
            ApiUrl<Summary> u = new ApiUrl<Summary>(suffix.statsSummary);
            u.AddParam(paramType.summonerId, 466244);
            u.AddParam(paramType.region, region.tr);
            u.AddParam(paramType.season, season.SEASON2016);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void summonerByname()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerByname);
            u.AddParam(paramType.summonerNames, new List<string>() { "Kesintisiz", "MustyMax" });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);

            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void summonerIds()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerIds);
            u.AddParam(paramType.summonerIds, new List<long>() { 466244, 311699 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }
    }
}