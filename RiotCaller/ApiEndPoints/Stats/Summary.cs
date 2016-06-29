using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.ApiEndPoints.Stats
{
    public class AggregatedStats
    {
        [JsonProperty("averageAssists")]
        public int? AverageAssists { get; set; }

        [JsonProperty("averageChampionsKilled")]
        public int? AverageChampionsKilled { get; set; }

        [JsonProperty("averageCombatPlayerScore")]
        public int? AverageCombatPlayerScore { get; set; }

        [JsonProperty("averageNodeCapture")]
        public int? AverageNodeCapture { get; set; }

        [JsonProperty("averageNodeCaptureAssist")]
        public int? AverageNodeCaptureAssist { get; set; }

        [JsonProperty("averageNodeNeutralize")]
        public int? AverageNodeNeutralize { get; set; }

        [JsonProperty("averageNodeNeutralizeAssist")]
        public int? AverageNodeNeutralizeAssist { get; set; }

        [JsonProperty("averageNumDeaths")]
        public int? AverageNumDeaths { get; set; }

        [JsonProperty("averageObjectivePlayerScore")]
        public int? AverageObjectivePlayerScore { get; set; }

        [JsonProperty("averageTeamObjective")]
        public int? AverageTeamObjective { get; set; }

        [JsonProperty("averageTotalPlayerScore")]
        public int? AverageTotalPlayerScore { get; set; }

        [JsonProperty("maxAssists")]
        public int? MaxAssists { get; set; }

        [JsonProperty("maxChampionsKilled")]
        public int? MaxChampionsKilled { get; set; }

        [JsonProperty("maxCombatPlayerScore")]
        public int? MaxCombatPlayerScore { get; set; }

        [JsonProperty("maxNodeCapture")]
        public int? MaxNodeCapture { get; set; }

        [JsonProperty("maxNodeCaptureAssist")]
        public int? MaxNodeCaptureAssist { get; set; }

        [JsonProperty("maxNodeNeutralize")]
        public int? MaxNodeNeutralize { get; set; }

        [JsonProperty("maxNodeNeutralizeAssist")]
        public int? MaxNodeNeutralizeAssist { get; set; }

        [JsonProperty("maxObjectivePlayerScore")]
        public int? MaxObjectivePlayerScore { get; set; }

        [JsonProperty("maxTeamObjective")]
        public int? MaxTeamObjective { get; set; }

        [JsonProperty("maxTotalPlayerScore")]
        public int? MaxTotalPlayerScore { get; set; }

        [JsonProperty("totalAssists")]
        public int TotalAssists { get; set; }

        [JsonProperty("totalChampionKills")]
        public int TotalChampionKills { get; set; }

        [JsonProperty("totalMinionKills")]
        public int TotalMinionKills { get; set; }

        [JsonProperty("totalNeutralMinionsKilled")]
        public int TotalNeutralMinionsKilled { get; set; }
        [JsonProperty("totalNodeCapture")]
        public int? TotalNodeCapture { get; set; }

        [JsonProperty("totalNodeNeutralize")]
        public int? TotalNodeNeutralize { get; set; }

        [JsonProperty("totalTurretsKilled")]
        public int TotalTurretsKilled { get; set; }
    }

    public class PlayerStatSummary
    {
        [JsonProperty("aggregatedStats")]
        public AggregatedStats AggregatedStats { get; set; }

        [JsonProperty("losses")]
        public int? Losses { get; set; }

        [JsonProperty("modifyDate")]
        public object ModifyDate { get; set; }

        [JsonProperty("playerStatSummaryType")]
        public PlayerStatsSummaryType PlayerStatSummaryType { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }

    public class Summary
    {
        [JsonProperty("playerStatSummaries")]
        public List<PlayerStatSummary> PlayerStatSummaries { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}