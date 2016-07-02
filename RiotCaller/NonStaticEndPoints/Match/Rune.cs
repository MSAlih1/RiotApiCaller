using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
{
    public class Rune
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("runeId")]
        public int RuneId { get; set; }
    }
}