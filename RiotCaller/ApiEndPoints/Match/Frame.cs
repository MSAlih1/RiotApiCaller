using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
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
