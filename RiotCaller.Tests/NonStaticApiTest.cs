using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints.Game;
using RiotCaller.EndPoints.League;
using RiotCaller.EndPoints.Match;
using RiotCaller.EndPoints.MatchList;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class NonStaticApiTest
    {
        [TestMethod]
        public void ExtensionGetRecentGames()
        {
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            RecentGames data1 = data.GetRecentGames();//extension
            Assert.IsNotNull(data1);
        }

        [TestMethod]
        public void ExtensionGetLeague()
        {
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            League data1 = data.GetLeague();//extension
            Assert.IsNotNull(data1);
        }

        [TestMethod]
        public void ExtensionGetMatchList()
        {
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            MatchList data1 = data.GetMatchList();//extension
            Assert.IsNotNull(data1);
        }
        [TestMethod]
        public void ExtensionGetTeams()
        {
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            List<Team> data1 = data.GetTeams();//extension
            Assert.IsTrue(data1.Count > 0);
        }

        [TestMethod]
        public void ExtensionGetStatsSummary()
        {
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            Summary data1 = data.GetStatsSummary();//extension
            Assert.IsNotNull(data1);
        }

        [TestMethod]
        public void GetMatchDetail()
        {
            NonStaticApi api = new NonStaticApi();
            MatchDetail data = api.GetMatchDetail(gameId1, Region, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetLeagueId()
        {
            NonStaticApi api = new NonStaticApi();
            League data = api.GetLeague(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetLeagueByIds()
        {
            NonStaticApi api = new NonStaticApi();
            List<List<League>> data = api.GetLeagues(new List<long>() { summonerId1, summonerId2 }, Region);
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
            Summary data = api.GetStatsSummary(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetSummonerByName()
        {
            NonStaticApi api = new NonStaticApi();
            Summoner data = api.GetSummoner(summonerName1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetSummonerByNames()
        {
            NonStaticApi api = new NonStaticApi();
            List<Summoner> data = api.GetSummoners(new List<string>() { summonerName1, summonerName2 }, Region);
            Assert.IsTrue(data.Count > 1);
        }

        [TestMethod]
        public void GetTeamByName()
        {
            NonStaticApi api = new NonStaticApi();
            Team data = api.GetTeam(teamName1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeamById()
        {
            NonStaticApi api = new NonStaticApi();
            Team data = api.GetTeam(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeamByNames()
        {
            NonStaticApi api = new NonStaticApi();
            List<Team> data = api.GetTeams(new List<string>() { teamName1, teamName2 }, Region);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetTeamsByIds()
        {
            NonStaticApi api = new NonStaticApi();
            List<Team> data = api.GetTeams(new List<long>() { summonerId1, summonerId2 }, Region);
            Assert.IsTrue(data.Count > 0);
        }

        private long summonerId1 = long.Parse(ConfigurationSettings.AppSettings["summonerId1"]);
        private long summonerId2 = long.Parse(ConfigurationSettings.AppSettings["summonerId2"]);
        private string summonerName1 = ConfigurationSettings.AppSettings["summonerName1"];
        private string summonerName2 = ConfigurationSettings.AppSettings["summonerName2"];
        private string teamName1 = ConfigurationSettings.AppSettings["teamId1"];
        private string teamName2 = ConfigurationSettings.AppSettings["teamId2"];
        private region Region = (region)Enum.Parse(typeof(region), ConfigurationSettings.AppSettings["region"]);
        private long gameId1 = long.Parse(ConfigurationSettings.AppSettings["gameId1"]);
    }
}