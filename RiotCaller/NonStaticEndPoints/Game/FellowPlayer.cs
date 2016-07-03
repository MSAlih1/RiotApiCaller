using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Game
{
    public class FellowPlayer
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}