﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.Api;
using RiotCaller.Api.Cache;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StaticEndPoints.Item;
using RiotCaller.StaticEndPoints.LanguageStrings;
using RiotCaller.StaticEndPoints.Map;
using RiotCaller.StaticEndPoints.Mastery;
using RiotCaller.StaticEndPoints.Realm;
using RiotCaller.StaticEndPoints.Runes;
using RiotCaller.StaticEndPoints.SummonerSpells;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class StaticApiTest
    {
        [TestMethod]
        public void GetVersions()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            List<string> data = staticapi.GetVersions(region.tr);
            Assert.IsTrue(data.Count>0);
        }

        [TestMethod]
        public void GetSummonerSpell()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            SummonerSpellData data = staticapi.GetSummonerSpell(1, region.tr, language.tr_TR, spellData.all);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetSummonerSpells()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            SummonerSpellList data = staticapi.GetSummonerSpells(region.tr, language.tr_TR,spellData.all);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetRuneById()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            RuneData data = staticapi.GetRune(5001, region.tr, language.tr_TR, runeListData.all);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetRunes()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            RuneList data = staticapi.GetRunes(region.tr, language.tr_TR, runeListData.all);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetRealm()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            Realm data = staticapi.GetRealm(region.tr);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetMasteryById()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            StaticEndPoints.Mastery.Mastery data = staticapi.GetMastery(6161, region.tr, language.tr_TR);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetMasteries()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            MasteryData data = staticapi.GetMasteries(region.tr, language.tr_TR);
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetMaps()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            MapData data = staticapi.GetMaps(region.tr, language.tr_TR);
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetLanguages()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            List<language> data = staticapi.GetLanguages(region.tr);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetLanguageStrings()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            LanguageStrings data = staticapi.GetLanguageStrings(region.tr, language.tr_TR);
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetItem()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            ItemData data = staticapi.GetItem(itemId1, region.tr, language.tr_TR, itemListData.all);// null is basic information
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetItems()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            Items data = staticapi.GetItems(region.tr, language.tr_TR, itemListData.all);// null is basic information
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetChampions()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
            Champions data = staticapi.GetChampions(region.tr, language.tr_TR, null);// null is basic information
            Assert.IsTrue(data.Data.Count > 0);
        }

        [TestMethod]
        public void GetChampionsById()
        {
            StaticApi staticapi = new StaticApi(new ApiCache());
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