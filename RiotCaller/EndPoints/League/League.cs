using Newtonsoft.Json;
using RiotCaller.Enums;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.League
{
    public class League
    {
        [JsonProperty("queue")]
        public queue Queue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }

        [JsonProperty("entries")]
        public List<Entry> Entries { get; set; }

        [JsonProperty("tier")]
        public Tier Tier { get; set; }
    }
}