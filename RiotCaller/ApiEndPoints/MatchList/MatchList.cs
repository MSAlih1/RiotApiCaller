using Newtonsoft.Json;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints
{
    public class MatchList
    {
        [JsonProperty("matches")]
        public List<Match> Matches { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }

        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
    }

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
