using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{
    public class ParticipantTimelineDeltas
    {
        [JsonProperty("zeroToTen")]
        public double ZeroToTen { get; set; }

        [JsonProperty("thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        [JsonProperty("tenToTwenty")]
        public double TenToTwenty { get; set; }

        [JsonProperty("twentyToThirty")]
        public double TwentyToThirty { get; set; }
    }

}
