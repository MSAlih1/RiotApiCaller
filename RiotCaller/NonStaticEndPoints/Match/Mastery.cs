using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
{
    public class Mastery
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }
    }
}