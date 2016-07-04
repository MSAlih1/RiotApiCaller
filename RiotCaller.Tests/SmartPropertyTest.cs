using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RiotCaller.Api.Service;
using RiotCaller.Enums;
using RiotCaller.NonStaticEndPoints.CurrentGame;
using System;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class SmartPropertyTest
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
        
        private string JsonCurrentGame = "{\"bannedChampions\":[{\"championId\":48,\"pickTurn\":1,\"teamId\":100},{\"championId\":8,\"pickTurn\":2,\"teamId\":200},{\"championId\":67,\"pickTurn\":3,\"teamId\":100},{\"championId\":238,\"pickTurn\":4,\"teamId\":200},{\"championId\":420,\"pickTurn\":5,\"teamId\":100},{\"championId\":105,\"pickTurn\":6,\"teamId\":200}],\"gameId\":410681096,\"gameLength\":1555,\"gameMode\":\"CLASSIC\",\"gameQueueConfigId\":\"TEAM_BUILDER_DRAFT_RANKED_5x5\",\"gameStartTime\":1466549178194,\"gameType\":\"MATCHED_GAME\",\"mapId\":\"11\",\"observers\":{\"encryptionKey\":\"nHV1KVL2CFHpnyoG/Ta0SgF9BWC/sGqw\"},\"participants\":[{\"bot\":false,\"championId\":201,\"masteries\":[{\"masteryId\":6212,\"rank\":5},{\"masteryId\":6223,\"rank\":1},{\"masteryId\":6232,\"rank\":5},{\"masteryId\":6242,\"rank\":1},{\"masteryId\":6251,\"rank\":5},{\"masteryId\":6263,\"rank\":1},{\"masteryId\":6311,\"rank\":5},{\"masteryId\":6322,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6342,\"rank\":1}],\"profileIconId\":690,\"runes\":[{\"count\":1,\"runeId\":5168},{\"count\":2,\"runeId\":5245},{\"count\":7,\"runeId\":5247},{\"count\":8,\"runeId\":5289},{\"count\":9,\"runeId\":5316},{\"count\":3,\"runeId\":5347}],\"spell1Id\":4,\"spell2Id\":3,\"summonerName\":\"Newbie Jhin\",\"teamId\":100},{\"bot\":false,\"championId\":39,\"masteries\":[{\"masteryId\":6111,\"rank\":5},{\"masteryId\":6122,\"rank\":1},{\"masteryId\":6131,\"rank\":5},{\"masteryId\":6142,\"rank\":1},{\"masteryId\":6151,\"rank\":5},{\"masteryId\":6162,\"rank\":1},{\"masteryId\":6312,\"rank\":5},{\"masteryId\":6323,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1}],\"profileIconId\":1129,\"runes\":[{\"count\":9,\"runeId\":5245},{\"count\":1,\"runeId\":5277},{\"count\":8,\"runeId\":5289},{\"count\":9,\"runeId\":5317},{\"count\":2,\"runeId\":5335},{\"count\":1,\"runeId\":5337}],\"spell1Id\":4,\"spell2Id\":12,\"summonerName\":\"Qoro\",\"teamId\":100},{\"bot\":false,\"championId\":127,\"masteries\":[{\"masteryId\":6114,\"rank\":5},{\"masteryId\":6122,\"rank\":1},{\"masteryId\":6134,\"rank\":5},{\"masteryId\":6142,\"rank\":1},{\"masteryId\":6311,\"rank\":5},{\"masteryId\":6323,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1},{\"masteryId\":6352,\"rank\":5},{\"masteryId\":6362,\"rank\":1}],\"profileIconId\":959,\"runes\":[{\"count\":9,\"runeId\":5273},{\"count\":9,\"runeId\":5297},{\"count\":9,\"runeId\":5317},{\"count\":3,\"runeId\":5357}],\"spell1Id\":14,\"spell2Id\":4,\"summonerName\":\"Yamı Yu Gi\",\"teamId\":100},{\"bot\":false,\"championId\":131,\"masteries\":[{\"masteryId\":6114,\"rank\":5},{\"masteryId\":6121,\"rank\":1},{\"masteryId\":6134,\"rank\":5},{\"masteryId\":6141,\"rank\":1},{\"masteryId\":6312,\"rank\":5},{\"masteryId\":6323,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1},{\"masteryId\":6351,\"rank\":5},{\"masteryId\":6362,\"rank\":1}],\"profileIconId\":546,\"runes\":[{\"count\":9,\"runeId\":5247},{\"count\":9,\"runeId\":5289},{\"count\":9,\"runeId\":5317},{\"count\":3,\"runeId\":5357}],\"spell1Id\":4,\"spell2Id\":11,\"summonerName\":\"cockstyle\",\"teamId\":100},{\"bot\":false,\"championId\":236,\"masteries\":[{\"masteryId\":6111,\"rank\":5},{\"masteryId\":6122,\"rank\":1},{\"masteryId\":6131,\"rank\":5},{\"masteryId\":6141,\"rank\":1},{\"masteryId\":6151,\"rank\":5},{\"masteryId\":6162,\"rank\":1},{\"masteryId\":6312,\"rank\":5},{\"masteryId\":6322,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1}],\"profileIconId\":615,\"runes\":[{\"count\":9,\"runeId\":5245},{\"count\":9,\"runeId\":5289},{\"count\":9,\"runeId\":5317},{\"count\":3,\"runeId\":5337}],\"spell1Id\":4,\"spell2Id\":7,\"summonerName\":\"Who Fed EscapeIV\",\"teamId\":100},{\"bot\":false,\"championId\":15,\"masteries\":[{\"masteryId\":6111,\"rank\":5},{\"masteryId\":6122,\"rank\":1},{\"masteryId\":6131,\"rank\":5},{\"masteryId\":6141,\"rank\":1},{\"masteryId\":6151,\"rank\":5},{\"masteryId\":6162,\"rank\":1},{\"masteryId\":6312,\"rank\":5},{\"masteryId\":6322,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1}],\"profileIconId\":789,\"runes\":[{\"count\":9,\"runeId\":5247},{\"count\":9,\"runeId\":5289},{\"count\":9,\"runeId\":5317},{\"count\":3,\"runeId\":5335}],\"spell1Id\":7,\"spell2Id\":4,\"summonerName\":\"pAzzi\",\"teamId\":200},{\"bot\":false,\"championId\":432,\"masteries\":[{\"masteryId\":6211,\"rank\":5},{\"masteryId\":6223,\"rank\":1},{\"masteryId\":6232,\"rank\":5},{\"masteryId\":6241,\"rank\":1},{\"masteryId\":6311,\"rank\":5},{\"masteryId\":6322,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6342,\"rank\":1},{\"masteryId\":6352,\"rank\":5},{\"masteryId\":6362,\"rank\":1}],\"profileIconId\":1113,\"runes\":[{\"count\":9,\"runeId\":5267},{\"count\":9,\"runeId\":5289},{\"count\":9,\"runeId\":5317},{\"count\":3,\"runeId\":5357}],\"spell1Id\":14,\"spell2Id\":4,\"summonerName\":\"IK0rkusuz\",\"teamId\":200},{\"bot\":false,\"championId\":38,\"masteries\":[{\"masteryId\":6114,\"rank\":5},{\"masteryId\":6121,\"rank\":1},{\"masteryId\":6134,\"rank\":5},{\"masteryId\":6142,\"rank\":1},{\"masteryId\":6312,\"rank\":5},{\"masteryId\":6322,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1},{\"masteryId\":6351,\"rank\":5},{\"masteryId\":6362,\"rank\":1}],\"profileIconId\":625,\"runes\":[{\"count\":9,\"runeId\":5273},{\"count\":9,\"runeId\":5289},{\"count\":9,\"runeId\":5317},{\"count\":3,\"runeId\":5357}],\"spell1Id\":12,\"spell2Id\":4,\"summonerName\":\"bojanglelks\",\"teamId\":200},{\"bot\":false,\"championId\":121,\"masteries\":[{\"masteryId\":6111,\"rank\":5},{\"masteryId\":6121,\"rank\":1},{\"masteryId\":6131,\"rank\":5},{\"masteryId\":6142,\"rank\":1},{\"masteryId\":6312,\"rank\":5},{\"masteryId\":6321,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1},{\"masteryId\":6351,\"rank\":5},{\"masteryId\":6362,\"rank\":1}],\"profileIconId\":598,\"runes\":[{\"count\":9,\"runeId\":5253},{\"count\":9,\"runeId\":5289},{\"count\":9,\"runeId\":5317},{\"count\":3,\"runeId\":5335}],\"spell1Id\":11,\"spell2Id\":4,\"summonerName\":\"Arteriyosklerox\",\"teamId\":200},{\"bot\":false,\"championId\":245,\"masteries\":[{\"masteryId\":6114,\"rank\":5},{\"masteryId\":6121,\"rank\":1},{\"masteryId\":6131,\"rank\":5},{\"masteryId\":6142,\"rank\":1},{\"masteryId\":6154,\"rank\":5},{\"masteryId\":6162,\"rank\":1},{\"masteryId\":6312,\"rank\":5},{\"masteryId\":6323,\"rank\":1},{\"masteryId\":6331,\"rank\":5},{\"masteryId\":6343,\"rank\":1}],\"profileIconId\":1149,\"runes\":[{\"count\":9,\"runeId\":5247},{\"count\":3,\"runeId\":5289},{\"count\":6,\"runeId\":5296},{\"count\":2,\"runeId\":5317},{\"count\":7,\"runeId\":5318},{\"count\":3,\"runeId\":5357}],\"spell1Id\":12,\"spell2Id\":4,\"summonerName\":\"Dracule Mihâwk\",\"teamId\":200}],\"platformId\":\"TR1\"}";

        /// <summary>
        /// 
        /// WARNING
        /// IF YOU DONT HAVE ENOUGH PHYSICAL MEMORY, YOU SHOULD NOT GET ALL DATA 
        /// FROM SERVER SELECT ONE WHAT YOU NEED
        ///
        /// </summary>
        [TestMethod]
        public void CacheMemoryTest()
        {
            ApiService svc = new ApiService();
            //one region's all static-datas take 21MB from physical memory
            svc.staticApi.GetChampions(Region, Region.ToPlatform().ToLanguage(), champData.all, true);
            svc.staticApi.GetItems(Region, Region.ToPlatform().ToLanguage(), itemListData.all, true);
            svc.staticApi.GetLanguages(Region, true);
            svc.staticApi.GetMaps(Region, Region.ToPlatform().ToLanguage(), true);
            svc.staticApi.GetMasteries(Region, Region.ToPlatform().ToLanguage(), masteryListData.all, true);
            svc.staticApi.GetRunes(Region, Region.ToPlatform().ToLanguage(), runeListData.all, true);
            svc.staticApi.GetSummonerSpells(Region, Region.ToPlatform().ToLanguage(), spellData.all, true);
            svc.staticApi.GetVersions(Region, true);

            //than you watch MB size on Diagnostic Tools 
            CurrentGame data = JsonConvert.DeserializeObject<CurrentGame>(JsonCurrentGame);
            svc.Smartproperty(data);//after every query, smartproperty faster than first query

        }


        [TestMethod]
        public void SmartProperty_CurrentGame()
        {
            ApiService svc = new ApiService();
            CurrentGame data = JsonConvert.DeserializeObject<CurrentGame>(JsonCurrentGame);
            svc.Smartproperty(data);//[from server] after every query, smartproperty faster than first query
            svc.Smartproperty(data);//from cache
            svc.Smartproperty(data);//from cache
            svc.Smartproperty(data);//from cache
        }
    }
}