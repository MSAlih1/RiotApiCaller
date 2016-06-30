using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{
    public class Participant
    {
        [JsonProperty("masteries")]
        public List<Mastery> Masteries { get; set; }

        [JsonProperty("stats")]
        public ParticipantStats Stats { get; set; }

        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }

        [JsonProperty("timeline")]
        public ParticipantTimeline Timeline { get; set; }

        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
    }
}
