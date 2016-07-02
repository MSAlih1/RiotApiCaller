using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
{
    public class Ban
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }
    }
}