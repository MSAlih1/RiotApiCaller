using Newtonsoft.Json;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{

    public class ParticipantTimeline
    {
        [JsonProperty("xpDiffPerMinDeltas")]
        public ParticipantTimelineDeltas XpDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public ParticipantTimelineDeltas DamageTakenDiffPerMinDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public ParticipantTimelineDeltas XpPerMinDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public ParticipantTimelineDeltas GoldPerMinDeltas { get; set; }

        [JsonProperty("role")]
        public role Role { get; set; }

        [JsonProperty("creepsPerMinDeltas")]
        public ParticipantTimelineDeltas CreepsPerMinDeltas { get; set; }

        [JsonProperty("csDiffPerMinDeltas")]
        public ParticipantTimelineDeltas CsDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public ParticipantTimelineDeltas DamageTakenPerMinDeltas { get; set; }

        [JsonProperty("lane")]
        public lane Lane { get; set; }
    }
}
