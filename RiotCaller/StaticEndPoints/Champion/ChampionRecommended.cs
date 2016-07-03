using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionRecommended
    {
        [JsonProperty("champion")]
        public string Champion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("blocks")]
        public List<ChampionBlock> Blocks { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}