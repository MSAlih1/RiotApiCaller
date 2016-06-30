using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.MatchList
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
}