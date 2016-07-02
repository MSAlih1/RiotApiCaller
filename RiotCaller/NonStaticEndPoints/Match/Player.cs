using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
{
    public class Player
    {
        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}