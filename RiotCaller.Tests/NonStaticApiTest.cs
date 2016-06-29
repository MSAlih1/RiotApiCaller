using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.ApiEndPoints.Stats;
using RiotCaller.ApiEndPoints.Summoner;
using RiotCaller.ApiEndPoints.Team;
using RiotCaller.Enums;
using System.Collections.Generic;


namespace RiotCaller.Tests
{
    [TestClass]
    public class NonStaticApiTest
    {
        [TestMethod]
        public void GetSummoner()
        {
            NonStaticApi api = new NonStaticApi();
            Summoner data = api.GetSummoner("kesintisiz");
            Assert.IsNotNull(data);

            var data2 = data.GetStatsRanked();//extension
            Assert.IsNotNull(data2);

            var data3 = data.GetStatsSummary();//extension
            Assert.IsNotNull(data3);
        }

        [TestMethod]
        public void GetSummoners()
        {
            NonStaticApi api = new NonStaticApi();
            List<Summoner> data = api.GetSummoners(new List<string>() { "kesintisiz", "mustymax" });
            Assert.IsTrue(data.Count > 1);
        }

        [TestMethod]
        public void GetStatsSummary()
        {
            NonStaticApi api = new NonStaticApi();
            var data = api.GetStatsSummary(466244);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetStatsRanked()
        {
            NonStaticApi api = new NonStaticApi();
            var data = api.GetStatsRanked(466244);
            Assert.IsNotNull(data);
        }

    }
}
