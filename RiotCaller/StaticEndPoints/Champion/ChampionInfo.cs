using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionInfo
    {
        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("magic")]
        public int Magic { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty("attack")]
        public int Attack { get; set; }
    }
}