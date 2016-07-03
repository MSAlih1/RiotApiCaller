using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Item;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Runes
{
    public class RuneList
    {
        [JsonProperty("basic")]
        public StaticBasic Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<int, RuneData> Runes { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}