using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Stats
{
    public class Summary
    {
        [JsonProperty("playerStatSummaries")]
        public List<PlayerStatSummary> PlayerStatSummaries { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}