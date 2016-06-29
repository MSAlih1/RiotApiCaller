using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.Classes.Summoner;
using System.Collections.Generic;

namespace RiotCaller.Tests
{
    [TestClass]
    public class ApiUrlTest
    {
        [TestMethod]
        public void summonerByname()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(Suffix.summonerByname);
            u.AddParam(ParamTypes.summonerNames, new List<string>() { "Kesintisiz", "MustyMax" });
            u.AddParam(ParamTypes.region, "tr");

            string result = u.Url;
            Assert.AreEqual("https://tr.api.pvp.net/api/lol/tr/v1.4/summoner/by-name/Kesintisiz,MustyMax", result);
        }

        [TestMethod]
        public void summonerMasteries()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(Suffix.summonerIds);
            u.AddParam(ParamTypes.summonerIds, new List<long>() { 466244, 457724 });
            u.AddParam(ParamTypes.region, "tr");
            string result = u.Url;
            Assert.AreEqual("https://tr.api.pvp.net/api/lol/tr/v1.4/summoner/466244,457724", result);
        }

        [TestMethod]
        public void leagueTeamIds()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(Suffix.leagueTeamIds);
            u.AddParam(ParamTypes.teamIds, new List<long>() { 80584218, 22155850 });
            u.AddParam(ParamTypes.region, "tr");
            string result = u.Url;

            Assert.AreEqual("https://tr.api.pvp.net/api/lol/tr/v2.5/league/by-team/80584218,22155850", result);
        }

        [TestMethod]
        public void statsRanked()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(Suffix.statsRanked);
            u.AddParam(ParamTypes.summonerId, 466244);
            u.AddParam(ParamTypes.region, "tr");
            string result = u.Url;

            Assert.AreEqual("https://tr.api.pvp.net/api/lol/tr/v1.3/stats/by-summoner/466244/ranked", result);
        }
    }
}