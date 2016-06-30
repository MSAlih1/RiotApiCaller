using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Match
{
    public class Frame
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("participantFrames")]
        public Dictionary<string, ParticipantFrames> ParticipantFrames { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }
    }
}