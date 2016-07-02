using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Team
{
    public class TeamStatDetail
    {
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}