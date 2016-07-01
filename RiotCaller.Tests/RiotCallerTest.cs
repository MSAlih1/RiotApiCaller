//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Ninject;
//using RiotCaller.ApiEndPoints;
//using RiotCaller.EndPoints.League;
//using RiotCaller.EndPoints.Match;
//using RiotCaller.EndPoints.MatchList;
//using RiotCaller.EndPoints.Stats;
//using RiotCaller.EndPoints.Team;
//using RiotCaller.Enums;
//using System;
//using System.Collections.Generic;
//using System.Configuration;

//namespace RiotCaller.Tests
//{
//    [TestClass]
//    public class RiotCallerTest
//    {
//        private long summonerId1 = long.Parse(ConfigurationSettings.AppSettings["summonerId1"]);
//        private long summonerId2 = long.Parse(ConfigurationSettings.AppSettings["summonerId2"]);

//        private string summonerName1 = ConfigurationSettings.AppSettings["summonerName1"];
//        private string summonerName2 = ConfigurationSettings.AppSettings["summonerName2"];

//        private string teamName1 = ConfigurationSettings.AppSettings["teamId1"];
//        private string teamName2 = ConfigurationSettings.AppSettings["teamId2"];

//        private region Region = (region)Enum.Parse(typeof(region), ConfigurationSettings.AppSettings["region"]);

//        private long gameId1 = long.Parse(ConfigurationSettings.AppSettings["gameId1"]);

//        [TestMethod]
//        public void matchdetail()
//        {
//            RiotApiCaller<MatchDetail> caller = new RiotApiCaller<MatchDetail>(suffix.matchdetail);
//            caller.AddParam(param.matchId, gameId1);
//            caller.AddParam(param.region, Region);
//            caller.AddParam(param.includeTimeline, false);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void matchlist()
//        {
//            RiotApiCaller<MatchList> caller = new RiotApiCaller<MatchList>(suffix.matchlist);
//            caller.AddParam(param.summonerId, new List<long>() { summonerId1 });
//            caller.AddParam(param.championIds, new List<long>() { 45, 25 });
//            caller.AddParam(param.rankedQueues, new List<queue>() { queue.RANKED_SOLO_5x5, queue.TEAM_BUILDER_DRAFT_RANKED_5x5 });
//            caller.AddParam(param.seasons, new List<season>() { season.SEASON2016 });
//            caller.AddParam(param.region, Region);
//            caller.AddParam(param.beginTime, DateTime.Now.AddMonths(-1));
//            caller.AddParam(param.endTime, DateTime.Now);
//            caller.AddParam(param.beginIndex, 0);
//            caller.AddParam(param.endIndex, 2);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }
//        [TestMethod]
//        public void statsRanked()
//        {
//            RiotApiCaller<Ranked> caller = new RiotApiCaller<Ranked>(suffix.statsRanked);
//            caller.AddParam(param.summonerId, 466244);
//            caller.AddParam(param.region, Region);
//            caller.AddParam(param.season, season.SEASON2016);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void statsSummary()
//        {
//            RiotApiCaller<Summary> caller = new RiotApiCaller<Summary>(suffix.statsSummary);
//            caller.AddParam(param.summonerId, 466244);
//            caller.AddParam(param.region, Region);
//            caller.AddParam(param.seasons, season.SEASON2016);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void summonerByname()
//        {
//            RiotApiCaller<Summoner> caller = new RiotApiCaller<Summoner>(suffix.summonerByname);
//            caller.AddParam(param.summonerNames, new List<string>() { summonerName1, summonerName1 });
//            caller.AddParam(param.region, Region);
//            caller.CreateRequest();

//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void summonerIds()
//        {
//            RiotApiCaller<Summoner> caller = new RiotApiCaller<Summoner>(suffix.summonerIds);
//            caller.AddParam(param.summonerIds, new List<long>() { summonerId1, summonerId1 });
//            caller.AddParam(param.region, Region);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void leagueByIds()
//        {
//            RiotApiCaller<List<League>> caller = new RiotApiCaller<List<League>>(suffix.leagueByIds);
//            caller.AddParam(param.summonerIds, new List<long>() { summonerId1, summonerId1 });
//            caller.AddParam(param.region, Region);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void leagueByIdsEntry()
//        {
//            RiotApiCaller<List<League>> caller = new RiotApiCaller<List<League>>(suffix.leagueByIdsEntry);
//            caller.AddParam(param.summonerIds, new List<long>() { summonerId1, summonerId1 });
//            caller.AddParam(param.region, Region);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void teamByIds()
//        {
//            RiotApiCaller<Team> caller = new RiotApiCaller<Team>(suffix.teamByIds);
//            caller.AddParam(param.teamIds, new List<string>() { teamName1 });
//            caller.AddParam(param.region, Region);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }

//        [TestMethod]
//        public void teamteamIds()
//        {
//            RiotApiCaller<List<Team>> caller = new RiotApiCaller<List<Team>>(suffix.teamIds);
//            caller.AddParam(param.summonerIds, new List<long>() { summonerId1, summonerId1 });
//            caller.AddParam(param.region, Region);
//            caller.CreateRequest();
//            Assert.IsTrue(caller.Result.Count > 0);
//        }
//    }
//}