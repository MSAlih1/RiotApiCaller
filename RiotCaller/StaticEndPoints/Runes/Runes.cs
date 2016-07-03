using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Runes
{
    public class Runes
    {

        [JsonProperty("basic")]
        public StaticBasic Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<int, RuneData> Runeler { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
