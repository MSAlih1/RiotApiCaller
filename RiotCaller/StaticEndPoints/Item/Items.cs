using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Item
{
    public class Items
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("basic")]
        public Basic Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<int, ItemData> Data { get; set; }

        [JsonProperty("groups")]
        public List<ItemGroup> Groups { get; set; }

        [JsonProperty("tree")]
        public List<ItemTree> Tree { get; set; }
    }
}
