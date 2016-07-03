using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.Api;
using RiotCaller.Api.Service;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StatusEndPoints.Shards;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class ApiServiceTest
    {
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