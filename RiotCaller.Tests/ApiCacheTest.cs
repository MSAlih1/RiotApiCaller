using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RiotCaller.Api;
using RiotCaller.Api.Service;
using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class ApiCacheTest
    {
        private string APIKEY = apikey.Key;

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


        /// <summary>
        /// CacheMemory's multipleKey ADD / GET test method
        /// </summary>
        [TestMethod]
        public void CGetChampions()
        {
            ApiService svc = new ApiService(APIKEY);
            Champions getting_from_server = svc.staticApi.GetChampions(region.tr, language.tr_TR, champData.all, true);

            Assert.IsTrue(getting_from_server.Data.Count > 0);

            svc.apiCache.AddWithMultipleKey("test123", "Object<Champions>+tr+tr_TR+all");//adding test key with orginkey(do not change manual orginkey)

            var getting_from_cache = svc.staticApi.GetChampions(region.tr, language.tr_TR, champData.all, true);//data coming from cache
            var geting_with_multiple_key = svc.apiCache.GetWithMultipleKey<Champions>("test123");

            Assert.IsNotNull(geting_with_multiple_key);
            Assert.IsTrue(geting_with_multiple_key.Data.Count > 0);
        }

        [TestMethod]
        public void CGetStatsRanked()
        {
            ApiService svc = new ApiService(APIKEY);
            Ranked data = svc.Api.GetStatsRanked(summonerId1, region.tr, null, true);
            Assert.IsNotNull(data);

            data = svc.Api.GetStatsRanked(summonerId1, region.tr, null, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void CGetSummoner()
        {
            ApiService svc = new ApiService(APIKEY);
            Summoner data = svc.Api.GetSummoner(summonerId1, region.tr, true);
            Assert.IsNotNull(data);

            data = svc.Api.GetSummoner(summonerId1, region.tr, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void CGetTeam()
        {
            ApiService svc = new ApiService(APIKEY);
            Team data = svc.Api.GetTeam(teamName1, region.tr, true);
            Assert.IsNotNull(data);

            data = svc.Api.GetTeam(teamName1, region.tr, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void CGetVersions()
        {
            ApiService svc = new ApiService(APIKEY);
            List<string> data = svc.staticApi.GetVersions(region.tr, true);
            Assert.IsTrue(data.Count > 0);

            data = svc.staticApi.GetVersions(region.tr, true);//data coming from cache
            Assert.IsTrue(data.Count > 0);
        }
    }
}