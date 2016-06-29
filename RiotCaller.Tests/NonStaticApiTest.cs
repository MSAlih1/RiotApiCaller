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
    public class NonStaticApiTest
    {
        long summonerId1 = long.Parse(ConfigurationSettings.AppSettings["summonerId1"]);
        long summonerId2 = long.Parse(ConfigurationSettings.AppSettings["summonerId2"]);

        string summonerName1 = ConfigurationSettings.AppSettings["summonerName1"];
        string summonerName2 = ConfigurationSettings.AppSettings["summonerName2"];

        string teamName1 = ConfigurationSettings.AppSettings["teamId1"];
        string teamName2 = ConfigurationSettings.AppSettings["teamId2"];

        [TestMethod]
        public void GetSummoner()
        {
            NonStaticApi api = new NonStaticApi();
            Summoner data = api.GetSummoner(summonerName1);
            Assert.IsNotNull(data);

            object data1 = data.GetStatsRanked();//extension
            Assert.IsNotNull(data1);

            data1 = data.GetStatsSummary();//extension
            Assert.IsNotNull(data1);

            data1 = data.GetTeams();//extension
            Assert.IsTrue((data1 as List<Team>).Count > 0);
        }
        [TestMethod]
        public void GetTeam()
        {
            NonStaticApi api = new NonStaticApi();
            Team data = api.GetTeam(teamName1);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeam2()
        {
            NonStaticApi api = new NonStaticApi();
            Team data = api.GetTeam(summonerId1);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeams()
        {
            NonStaticApi api = new NonStaticApi();
            List<Team> data = api.GetTeams(new List<string>() { teamName1, teamName2 });
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetTeams2()
        {
            NonStaticApi api = new NonStaticApi();
            List<Team> data = api.GetTeams(new List<long>() { summonerId1, summonerId2 });
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetSummoners()
        {
            NonStaticApi api = new NonStaticApi();
            List<Summoner> data = api.GetSummoners(new List<string>() { summonerName1, summonerName2 });
            Assert.IsTrue(data.Count > 1);
        }

        [TestMethod]
        public void GetStatsSummary()
        {
            NonStaticApi api = new NonStaticApi();
            var data = api.GetStatsSummary(summonerId1);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetStatsRanked()
        {
            NonStaticApi api = new NonStaticApi();
            var data = api.GetStatsRanked(summonerId1);
            Assert.IsNotNull(data);
        }

    }
}
