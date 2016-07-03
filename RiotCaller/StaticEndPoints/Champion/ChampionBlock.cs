using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionBlock
    {
        [JsonProperty("recMath")]
        public bool RecMath { get; set; }

        [JsonProperty("items")]
        public List<ChampionItems> Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}