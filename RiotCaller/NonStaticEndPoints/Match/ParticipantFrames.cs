using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
{
    public class ParticipantFrames
    {
        [JsonProperty("currentGold")]
        public int CurrentGold { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }

        [JsonProperty("totalGold")]
        public int TotalGold { get; set; }

        [JsonProperty("dominionScore")]
        public int DominionScore { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("xp")]
        public int Xp { get; set; }

        [JsonProperty("teamScore")]
        public int TeamScore { get; set; }
    }
}