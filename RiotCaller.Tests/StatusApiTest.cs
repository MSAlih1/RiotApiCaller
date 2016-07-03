using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotCaller.Api;
using RiotCaller.StatusEndPoints.Shards;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RiotCaller.Tests
{
    [TestClass]
    public class StatusApiTest
    {
        [TestMethod]
        public void GetShards()
        {
            StatusApi statusapi = new StatusApi();
            List<Shards> data = statusapi.GetShards();
            Assert.IsTrue(data.Count>1);
        }
        
    }
}