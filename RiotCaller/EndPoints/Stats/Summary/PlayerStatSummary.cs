using Newtonsoft.Json;
using RiotCaller.EndPoints.Enums;

namespace RiotCaller.EndPoints.Stats
{
    public class PlayerStatSummary
    {
        [JsonProperty("aggregatedStats")]
        public AggregatedStats AggregatedStats { get; set; }

        [JsonProperty("losses")]
        public int? Losses { get; set; }

        [JsonProperty("modifyDate")]
        public object ModifyDate { get; set; }

        [JsonProperty("playerStatSummaryType")]
        public playerStatsSummaryType PlayerStatSummaryType { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}