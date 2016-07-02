using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
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