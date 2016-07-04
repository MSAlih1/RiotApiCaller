using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Mastery;

namespace RiotCaller.EndPoints.Match
{
    public class Mastery
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        /// <summary>
        /// smarty property
        /// </summary>
        [JsonIgnore]
        public RiotCaller.StaticEndPoints.Mastery.Mastery MasteryInfo { get; set; }
    }
}