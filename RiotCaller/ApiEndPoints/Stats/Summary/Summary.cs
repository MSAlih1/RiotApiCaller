using Newtonsoft.Json;
using RiotCaller.ApiEndPoints.Enums;
using System.Collections.Generic;

namespace RiotCaller.ApiEndPoints.Stats
{
    public class Summary
    {
        [JsonProperty("playerStatSummaries")]
        public List<PlayerStatSummary> PlayerStatSummaries { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}