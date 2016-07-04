using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RiotCaller.Api;
using RiotCaller.Api.Service;
using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using RiotCaller.NonStaticEndPoints.CurrentGame;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StatusEndPoints.Shards;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class ApiCacheTest
    {
        private long championId1 = long.Parse(ConfigurationSettings.AppSettings["championId1"]);

        private long gameId1 = long.Parse(ConfigurationSettings.AppSettings["gameId1"]);

        private long itemId1 = long.Parse(ConfigurationSettings.AppSettings["itemId1"]);

        private region Region = (region)Enum.Parse(typeof(region), ConfigurationSettings.AppSettings["region"]);

        private long summonerId1 = long.Parse(ConfigurationSettings.AppSettings["summonerId1"]);

        private long summonerId2 = long.Parse(ConfigurationSettings.AppSettings["summonerId2"]);

        private string summonerName1 = ConfigurationSettings.AppSettings["summonerName1"];

        private string summonerName2 = ConfigurationSettings.AppSettings["summonerName2"];

        private string teamName1 = ConfigurationSettings.AppSettings["teamId1"];

        private string teamName2 = ConfigurationSettings.AppSettings["teamId2"];


        [TestMethod]
        public void CGetChampions()
        {
            ApiService svc = new ApiService();
            Champions data = svc.staticApi.GetChampions(region.tr, language.tr_TR, champData.all, true);
            Assert.IsTrue(data.Data.Count > 0);

            data = svc.staticApi.GetChampions(region.tr, language.tr_TR, champData.all, true);//data coming from cache
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void CGetStatsRanked()
        {
            ApiService svc = new ApiService();
            Ranked data = svc.Api.GetStatsRanked(summonerId1, region.tr, null, true);
            Assert.IsNotNull(data);

            data = svc.Api.GetStatsRanked(summonerId1, region.tr, null, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void CGetSummoner()
        {
            ApiService svc = new ApiService();
            Summoner data = svc.Api.GetSummoner(summonerId1, region.tr, true);
            Assert.IsNotNull(data);

            data = svc.Api.GetSummoner(summonerId1, region.tr, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void CGetTeam()
        {
            ApiService svc = new ApiService();
            Team data = svc.Api.GetTeam(teamName1, region.tr, true);
            Assert.IsNotNull(data);

            data = svc.Api.GetTeam(teamName1, region.tr, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void CGetVersions()
        {
            ApiService svc = new ApiService();
            List<string> data = svc.staticApi.GetVersions(region.tr, true);
            Assert.IsTrue(data.Count > 0);

            data = svc.staticApi.GetVersions(region.tr, true);//data coming from cache
            Assert.IsTrue(data.Count > 0);
        }
    }
}