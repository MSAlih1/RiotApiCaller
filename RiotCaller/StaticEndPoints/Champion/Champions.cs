using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class Champions
    {
        [JsonProperty("keys")]
        public Dictionary<int, string> Keys { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, ChampionData> Data { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
