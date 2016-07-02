using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.ApiEndPoints;
using RiotCaller.EndPoints.ChampionMastery;
using RiotCaller.EndPoints.ChampionRotation;
using RiotCaller.EndPoints.FuturedGames;
using RiotCaller.EndPoints.Game;
using RiotCaller.EndPoints.League;
using RiotCaller.EndPoints.Match;
using RiotCaller.EndPoints.MatchList;
using RiotCaller.EndPoints.Stats;
using RiotCaller.EndPoints.Team;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StaticEndPoints.Item;
using RiotCaller.StaticEndPoints.LanguageStrings;
using RiotCaller.StaticEndPoints.Map;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class StaticApiTest
    {
        [TestMethod]
        public void GetMaps()
        {
            StaticApi staticapi = new StaticApi();
            MapData data = staticapi.GetMaps(region.tr, language.tr_TR);
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetLanguages()
        {
            StaticApi staticapi = new StaticApi();
            List<language> data = staticapi.GetLanguages(region.tr);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetLanguageStrings()
        {
            StaticApi staticapi = new StaticApi();
            LanguageStrings data = staticapi.GetLanguageStrings(region.tr, language.tr_TR);
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetItem()
        {
            StaticApi staticapi = new StaticApi();
            ItemData data = staticapi.GetItem(itemId1, region.tr, language.tr_TR, itemListData.all);// null is basic information
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetItems()
        {
            StaticApi staticapi = new StaticApi();
            Items data = staticapi.GetItems(region.tr, language.tr_TR, itemListData.all);// null is basic information
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetChampions()
        {
            StaticApi staticapi = new StaticApi();
            Champions data = staticapi.GetChampions(region.tr, language.tr_TR, null);// null is basic information
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetChampionsById()
        {
            StaticApi staticapi = new StaticApi();
            ChampionData data = staticapi.GetChampion(championId1, region.tr, language.tr_TR, null);// null is basic information
            Assert.IsNotNull(data);
        }

        private long itemId1 = long.Parse(ConfigurationSettings.AppSettings["itemId1"]);
        private long championId1 = long.Parse(ConfigurationSettings.AppSettings["championId1"]);
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