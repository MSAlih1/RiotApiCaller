using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Runes;

namespace RiotCaller.EndPoints.Match
{
    public class Rune
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("runeId")]
        public int RuneId { get; set; }

        /// <summary>
        /// smarty property
        /// </summary>
        [JsonIgnore]
        public RuneData RuneInfo { get; set; }
    }
}