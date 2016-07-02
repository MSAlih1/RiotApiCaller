using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using System;

namespace RiotCaller.EndPoints.MatchList
{
    public class Match
    {
        [JsonProperty("region")]
        public region Region { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("matchId")]
        public long MatchId { get; set; }

        [JsonProperty("champion")]
        public long Champion { get; set; }

        [JsonProperty("queue")]
        public queue Queue { get; set; }

        [JsonProperty("season")]
        public season Season { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("lane")]
        public lane Lane { get; set; }

        [JsonProperty("role")]
        public role Role { get; set; }
    }
}