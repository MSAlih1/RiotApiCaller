using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Item
{
    public class Items
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("basic")]
        public StaticBasic Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<int, ItemData> Data { get; set; }

        [JsonProperty("groups")]
        public List<ItemGroup> Groups { get; set; }

        [JsonProperty("tree")]
        public List<ItemTree> Tree { get; set; }
    }
}