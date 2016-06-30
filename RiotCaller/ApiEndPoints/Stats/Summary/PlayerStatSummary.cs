using Newtonsoft.Json;
using RiotCaller.ApiEndPoints.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Stats
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
