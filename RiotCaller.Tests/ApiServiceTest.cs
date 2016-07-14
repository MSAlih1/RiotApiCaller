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
    public class ApiServiceTest
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
        
        [TestMethod]
        public void ApiServiceTestWithKey()
        {
            ApiService svc = new ApiService(APIKEY);
            Ranked data = svc.Api.GetStatsRanked(summonerId1, region.tr, null, true);
            Assert.IsNotNull(data);
        }
    }
}