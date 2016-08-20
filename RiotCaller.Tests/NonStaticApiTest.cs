using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RiotCaller.Api;
using RiotCaller.Api.Service;
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
using RiotCaller.NonStaticEndPoints.CurrentGame;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class NonStaticApiTest
    {
        private string APIKEY = apikey.Key;
        [TestMethod]
        public void GetCurrentGame()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            CurrentGame data = api.GetCurrentGame(summonerId1, Region);
        }

        [TestMethod]
        public void ExtensionGetRecentGames()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            RecentGames data1 = data.GetRecentGames();//extension
            Assert.IsNotNull(data1);
        }

        [TestMethod]
        public void ExtensionGetLeague()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            League data1 = data.GetLeague();//extension
            Assert.IsNotNull(data1);
        }

        [TestMethod]
        public void ExtensionGetMatchList()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            MatchList data1 = data.GetMatchList();//extension
            Assert.IsNotNull(data1);
        }

        [TestMethod]
        public void ExtensionGetTeams()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            List<Team> data1 = data.GetTeams();//extension
            Assert.IsTrue(data1.Count > 0);
        }

        [TestMethod]
        public void ExtensionGetStatsSummary()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            Summoner data = new Summoner() { Id = summonerId1, Region = Region };
            Summary data1 = data.GetStatsSummary();//extension
            Assert.IsNotNull(data1);
        }

        [TestMethod]
        public void GetChampionRotation()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            ChampionRotation data = api.GetChampionRotation(region.tr, true);
            Assert.IsTrue(data.Champions.Count > 0);
        }

        [TestMethod]
        public void GetChampionRotationByChampId()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            ChampionStatus data = api.GetChampionRotationById(region.tr, championId1);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetChampionScore()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            int data = api.GetChampionMasteryScore(summonerId1, Region);
            Assert.IsTrue(data > 0);

        }

        [TestMethod]
        public void GetChampionTop()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            List<ChampionMastery> data = api.GetChampionMasteryTop(summonerId1, Region, 4);
            Assert.IsTrue(data.Count == 4);

        }

        [TestMethod]
        public void GetChampionMastery()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            ChampionMastery data = api.GetChampionMastery(summonerId1, championId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetChampionMasteries()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            List<ChampionMastery> data = api.GetChampionMasteries(summonerId1, Region);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetFuturedGames()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            FuturedGames data = api.GetFuturedGames(Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetMatchDetail()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            MatchDetail data = api.GetMatchDetail(gameId1, Region, true);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetLeagueId()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            summonerId1 = 1781187;
            League data = api.GetLeague(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetLeagueByIds()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            List<List<League>> data = api.GetLeagues(new List<long>() { summonerId1, summonerId2 }, Region);
            Assert.IsTrue(data.Count > 1);
        }

        [TestMethod]
        public void GetMatchList()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            MatchList data = api.GetMatchList(summonerId1, region.tr);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetStatsRanked()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            var data = api.GetStatsRanked(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetStatsSummary()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            Summary data = api.GetStatsSummary(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetSummonerByName()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            Summoner data = api.GetSummoner(summonerName1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetSummonerByNames()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            List<Summoner> data = api.GetSummoners(new List<string>() { summonerName1, summonerName2 }, Region);
            Assert.IsTrue(data.Count > 1);
        }

        [TestMethod]
        public void GetTeamByName()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            Team data = api.GetTeam(teamName1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeamById()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            Team data = api.GetTeam(summonerId1, Region);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetTeamByNames()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            List<Team> data = api.GetTeams(new List<string>() { teamName1, teamName2 }, Region);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        public void GetTeamsByIds()
        {
            ApiService.ApiKey = APIKEY;//you must add your project, if you dont use ninject
            NonStaticApi api = new NonStaticApi(new Api.Cache.ApiCache());
            List<Team> data = api.GetTeams(new List<long>() { summonerId1, summonerId2 }, Region);
            Assert.IsTrue(data.Count > 0);
        }

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