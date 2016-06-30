using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.ApiEndPoints;
using RiotCaller.ApiEndPoints.League;
using RiotCaller.ApiEndPoints.Match;
using RiotCaller.ApiEndPoints.MatchList;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class NonStaticApiTest
    {
        private long summonerId1 = long.Parse(ConfigurationSettings.AppSettings["summonerId1"]);
        private long summonerId2 = long.Parse(ConfigurationSettings.AppSettings["summonerId2"]);

        private string summonerName1 = ConfigurationSettings.AppSettings["summonerName1"];
        private string summonerName2 = ConfigurationSettings.AppSettings["summonerName2"];

        private string teamName1 = ConfigurationSettings.AppSettings["teamId1"];
        private string teamName2 = ConfigurationSettings.AppSettings["teamId2"];

        private region Region = (region)Enum.Parse(typeof(region), ConfigurationSettings.AppSettings["region"]);

        [TestMethod]
        public void GetLeague()
        {
            NonStaticApi api = new NonStaticApi();
            League data = api.GetLeague(summonerId1, Region);
            Assert.IsNotNull(data);
        }
        [TestMethod]
        public void GetLeagues()
        {
            NonStaticApi api = new NonStaticApi();
            List<List<League>> data = api.GetLeagues(new List<long>() { summonerId1,summonerId2}, Region);
            Assert.IsTrue(data.Count > 1);
        }
        [TestMethod]
        public void GetMatchList()
        {
            NonStaticApi api = new NonStaticApi();
            MatchList data = api.GetMatchList(summonerId1, region.tr);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetStatsRanked()
        {
            NonStaticApi api = new NonStaticApi();
            var data = api.GetStatsRanked(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetStatsSummary()
        {
            NonStaticApi api = new NonStaticApi();
            var data = api.GetStatsSummary(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetSummoner()
        {
            NonStaticApi api = new NonStaticApi();
            Summoner data = api.GetSummoner(summonerName1, Region);
            Assert.IsNotNull(data);

            object data1 = data.GetStatsRanked();//extension
            Assert.IsNotNull(data1);

            data1 = data.GetStatsSummary();//extension
            Assert.IsNotNull(data1);

            data1 = data.GetTeams();//extension
            Assert.IsTrue((data1 as List<ApiEndPoints.Team.Team>).Count > 0);

            data1 = data.GetMatchList();//extension
            Assert.IsNotNull(data1 as MatchList);

            data1 = data.GetLeague();//extension
            Assert.IsNotNull(data1 as League);
        }

        [TestMethod]
        public void GetSummoners()
        {
            NonStaticApi api = new NonStaticApi();
            List<Summoner> data = api.GetSummoners(new List<string>() { summonerName1, summonerName2 }, Region);
            Assert.IsTrue(data.Count > 1);
        }

        [TestMethod]
        public void GetTeam()
        {
            NonStaticApi api = new NonStaticApi();
            MatchDetailTeam data = api.GetTeam(teamName1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeam2()
        {
            NonStaticApi api = new NonStaticApi();
            MatchDetailTeam data = api.GetTeam(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeams()
        {
            NonStaticApi api = new NonStaticApi();
            List<MatchDetailTeam> data = api.GetTeams(new List<string>() { teamName1, teamName2 }, Region);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetTeams2()
        {
            NonStaticApi api = new NonStaticApi();
            List<MatchDetailTeam> data = api.GetTeams(new List<long>() { summonerId1, summonerId2 }, Region);
            Assert.IsTrue(data.Count > 0);
        }
    }
}