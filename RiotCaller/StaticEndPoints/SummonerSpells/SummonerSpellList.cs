using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.SummonerSpells
{
    public class SummonerSpellList
    {
        [JsonProperty("data")]
        public Dictionary<string, SummonerSpellData> SummonerSpells { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}